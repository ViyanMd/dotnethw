namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btInitial_Click(object sender, EventArgs e)
        {
            var count = 1;
            var charCount = 0;
            const string textName = "Name:";
            const string captionName = "My name is Viyan.";
            charCount += captionName.Length;
            var resultName = MessageBox.Show(captionName, textName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultName == DialogResult.OK)
            {
                count++;
                const string textEducation = "Education:";
                const string captionEducation = "I have a Bachelor's degree in International Business.";
                charCount += captionEducation.Length;
                var resultEducation = MessageBox.Show(captionEducation, textEducation, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (resultEducation == DialogResult.OK)
                {
                    count++;
                    const string textOrigin = "Origin:";
                    const string captionOrigin = "I come from Ukraine.";
                    charCount += captionOrigin.Length;
                    var resultOrigin = MessageBox.Show(captionOrigin, textOrigin, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (resultOrigin == DialogResult.OK)
                    {
                        count++;
                        const string textOccupation = "Occupation:";
                        const string captionOccupation = "And I am a software engineering student.";
                        charCount += captionOccupation.Length;
                        var resultOccupation = MessageBox.Show(captionOccupation, textOccupation, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            const string textStat = "Statistics: ";
            string captionStat = "You've visited: " + count + " MessageBoxes";
            string charStat = "You've read: " + charCount + " letters";
            MessageBox.Show(captionStat + '\n' + charStat, textStat, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void lbMainFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
