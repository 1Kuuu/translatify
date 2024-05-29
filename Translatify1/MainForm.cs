using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Translatify1
{
    public partial class MainForm : Form
    {
        #region Fields
        public Point mouseLocation;

        private readonly HttpClient _httpClient;
        private readonly Dictionary<string, string> _languageNames = new Dictionary<string, string>
        {
            { "en", "English" },
            { "es", "Spanish" },
            { "fr", "French" },
            { "de", "German" },
            { "it", "Italian" },
            { "pt", "Portuguese" },
            { "nl", "Dutch" },
            { "ru", "Russian" },
            { "zh", "Chinese" },
            { "ja", "Japanese" },
            { "ko", "Korean" },
            { "ar", "Arabic" }
        };

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        #endregion

        #region Event Handlers

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComboBoxes();
            SetControlBorders();
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textInput.Text) || string.IsNullOrEmpty(textOutput.Text))
            {
                MessageBox.Show("Please input a valid text");
            }
            else
            {
                await TranslateTextAsync();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
        }

        private void inptcpy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textInput.Text))
            {
                MessageBox.Show("Text box is empty. Please enter some text to copy.", "Warning");
            }
            else
            {
                Clipboard.SetText(textInput.Text);
            }
        }

        private void inptpste_Click(object sender, EventArgs e)
        {
            textInput.Text = Clipboard.GetText();
        }

        private void otptcpy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textOutput.Text))
            {
                MessageBox.Show("Text box is empty. Please enter some text to copy.", "Warning");
            }
            else
            {
                Clipboard.SetText(textOutput.Text);
            }
        }

        private void otptpste_Click(object sender, EventArgs e)
        {
            textOutput.Text = Clipboard.GetText();
        }

        #endregion

        #region Private Methods

        private async Task TranslateTextAsync()
        {
            try
            {
                if (textInput.Text.Length > 500)
                {
                    MessageBox.Show("The max character limit for the input is 500! Current input has: " + textInput.Text.Length);
                    return;
                }

                string sourceLangCode = GetLanguageCode(cmbSourceLanguage.SelectedItem.ToString());
                string targetLangCode = GetLanguageCode(cmbTargetLanguage.SelectedItem.ToString());

                string translatedText = await TranslateAsync(textInput.Text, sourceLangCode, targetLangCode);
                textOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Translation failed. Please try again. Error: \r\n" + ex.Message);
            }
        }

        private async Task<string> TranslateAsync(string text, string sourceLang, string targetLang)
        {
            string url = $"http://api.mymemory.translated.net/get?q={Uri.EscapeDataString(text)}&langpair={sourceLang}|{targetLang}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var translationResult = JsonConvert.DeserializeObject<TranslationResponse>(responseJson);

            if (translationResult.ResponseStatus == 200)
            {
                return translationResult.TranslatedText;
            }

            return string.Empty;
        }

        private void InitializeComboBoxes()
        {
            cmbSourceLanguage.Items.AddRange(_languageNames.Values.ToArray());
            cmbTargetLanguage.Items.AddRange(_languageNames.Values.ToArray());
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private void SetControlBorders()
        {
            textInput.BorderRadius = 20;
            textOutput.BorderRadius = 20;
            cmbSourceLanguage.BorderRadius = 17;
            cmbTargetLanguage.BorderRadius = 17;
        }

        private string GetLanguageCode(string languageName)
        {
            return _languageNames.FirstOrDefault(x => x.Value == languageName).Key;
        }

        #endregion

        #region Helper Classes

        public class TranslationResponse
        {
            [JsonProperty("responseStatus")]
            public int ResponseStatus { get; set; }

            [JsonProperty("responseData")]
            public TranslationData ResponseData { get; set; }

            public string TranslatedText => ResponseData?.TranslatedText;
        }

        public class TranslationData
        {
            [JsonProperty("translatedText")]
            public string TranslatedText { get; set; }
        }

        #endregion

        private void textInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTranslate.PerformClick();
            }
        }

        private void mouse_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private async void textInput_TextChanged(object sender, EventArgs e)
        {
            await TranslateTextAsync();
        }
    }
}