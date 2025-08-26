using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class WordManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtSearch.Text.Trim();
            lblWordToTranslate.Text = word;

            if (WordStore.ContainsWord(word))
            {
                lblSearchResult.Text = $"Found: {word}";
                txtTranslation.Text = WordStore.Words[word];
            }
            else
            {
                lblSearchResult.Text = $"'{word}' is not present. You can add it with a translation.";
                txtTranslation.Text = "";
            }
        }

        protected void btnAddTranslation_Click(object sender, EventArgs e)
        {
            string word = lblWordToTranslate.Text;
            string translation = txtTranslation.Text.Trim();

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translation))
            {
                WordStore.AddOrUpdate(word, translation);
                BindGrid();
                lblSearchResult.Text = $"'{word}' added/updated successfully.";
            }

        }
        private void BindGrid()
        {
            gvWords.DataSource = WordStore.GetAllWords();
            gvWords.DataBind();
        }

    }
}