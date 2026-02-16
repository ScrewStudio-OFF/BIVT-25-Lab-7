namespace Lab7.Blue
{
    public class Task4
    {
        public struct Team
        {
            //fields
            private string _name;
            private int[] _scores;

            //parameters
            public string Name => _name;
            public int[] Scores => (int[])_scores.Clone();

            public int TotalScore
            {
                get
                {
                    int summ = 0;
                    foreach (int i in _scores)
                    {
                        summ += i;
                    }
                    return summ;
                }
            }

            //methods
            public void PlayMatch(int result)
            {
                
            }

            //constructor
            public Team (string name)
            {
                _name = name;
                _scores = new int[0];
            }
        }

        public struct Group
        {
            //fields
            private string _name;
            private Team _teams;

            //parametrs
            public string Name => _name;
            public Team Teams => _teams;

            //constructor
            public Group ()
        }
    }
}