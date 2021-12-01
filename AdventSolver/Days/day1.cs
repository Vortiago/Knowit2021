namespace Days
{
    public class Day1
    {
        private string input;

        public Day1(string input) {
            this.input = input;
        }

        public IEnumerable<Int64> ParseBook() {
            var list = new List<Int64>();
            while(input.Length > 0) {
                list.Add(ParseWord());
            }

            return list;
        }

        public Int64 ParseWord()
        {
            if (CheckValue("femti")) return 50;
            else if (CheckValue("førti")) return 40;
            else if (CheckValue("tretti")) return 30;
            else if (CheckValue("tjue")) return 20;
            else if (CheckValue("nitten")) return 19;
            else if (CheckValue("atten")) return 18;
            else if (CheckValue("sytten")) return 17;
            else if (CheckValue("seksten")) return 16;
            else if (CheckValue("femten")) return 15;
            else if (CheckValue("fjorten")) return 14;
            else if (CheckValue("tretten")) return 13;
            else if (CheckValue("tolv")) return 12;
            else if (CheckValue("elleve")) return 11;
            else if (CheckValue("ti")) return 10;
            else if (CheckValue("ni")) return 9;
            else if (CheckValue("åtte")) return 8;
            else if (CheckValue("sju")) return 7;
            else if (CheckValue("seks")) return 6;
            else if (CheckValue("fem")) return 5;
            else if (CheckValue("fire")) return 4;
            else if (CheckValue("tre")) return 3;
            else if (CheckValue("to")) return 2;
            else if (CheckValue("en")) return 1;
            input = input.Remove(0, 1);
            return 0;
        }

        private bool CheckValue(string word) {
            if (input.StartsWith(word)) {
                input = input.Remove(0, word.Length);
                return true;
            }
            
            return false;
        }
    }
}