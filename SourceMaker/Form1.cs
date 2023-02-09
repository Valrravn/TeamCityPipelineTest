using System.Windows.Forms.VisualStyles;

namespace SourceMaker {
    public partial class Form1 : Form {

        string writePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\Data\\Result.txt"));

        public Form1() {
            InitializeComponent();

            #region Generate Data
            List<string> words = new List<string>() { 
                "Ebreitas", "Micolash", "Lawrence", "Ludwig", "Amygdala", "Paarl", "Logarius", "Amelia", "Moon Presence", "Gehrman" };
            DateTime dt = GetDate();
            int number = GetNumber();
            string bossName = GetWord(words, number);
            #endregion

            #region Write Results
            File.WriteAllText(writePath, String.Empty);
            File.WriteAllLines(writePath, new string[] { dt.ToString(), number.ToString(), bossName });
            #endregion

            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e) {
            this.Close();
        }

        public DateTime GetDate() {
            return DateTime.Now;
        }

        public int GetNumber() {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }

        public string GetWord(List<string> source, int i) {
            return source[i];
        }
    }
}