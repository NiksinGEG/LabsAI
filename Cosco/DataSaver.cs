using System.Text;

namespace Cosco
{
    public class DataSaver
    {
        public static void Save(string filename, SaveDataModel model)
        {
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                var sb = new StringBuilder();

                bool first = true;
                foreach (var px in model.Image)
                {
                    if (!first) sb.Append(",");
                    sb.Append($"{px}");
                    first = false;
                }
                sw.WriteLine(sb.ToString());

                first = true;
                sb.Clear();
                foreach (var px in model.Association)
                {
                    if (!first) sb.Append(",");
                    sb.Append($"{px}");
                    first = false;
                }
                sw.WriteLine(sb.ToString());
            }
        }

        public static IEnumerable<SaveDataModel> FromFile(string filename)
        {
            var res = new List<SaveDataModel>();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    var line1 = sr.ReadLine();
                    var line2 = sr.ReadLine();
                    if (string.IsNullOrEmpty(line1) || string.IsNullOrEmpty(line2)) continue;

                    var model = new SaveDataModel()
                    {
                        Image = line1.Trim().Split(',').Select(px => int.Parse(px)),
                        Association = line2.Trim().Split(',').Select(px => int.Parse(px))
                    };

                    res.Add(model);
                }
            }
            return res;
        }
    }
}
