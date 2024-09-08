namespace Pepris {
    internal class Scores {
        static string defaultDirectory = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "scores");

        public Scores() {
            Directory.CreateDirectory(defaultDirectory);
        }

        public void SaveScore(DateTime date, int time, int lines, string name) {
            string filePath = Path.Combine(defaultDirectory, DateTime.Now.ToString("yyyyMMddHHmmss") + ".pscr");
            string[] content = { date.ToString(), time.ToString(), lines.ToString(), name };

            File.WriteAllLines(filePath, content);
        }

        public string[] GetAllScoresPaths() {
            List<string> paths = new List<string>(Directory.GetFiles(defaultDirectory));
            return paths.ToArray();
        }

        public string[] LoadScore(string path) {
            return File.ReadAllLines(path);
        }
    }
}
