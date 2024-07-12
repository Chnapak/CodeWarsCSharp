namespace CodeWars
{
    public class UnknownProblem
    {
        public string Run()
        {
            string str = "kata";
            string distinct = string.Empty;

            if ((distinct = (string)(str.ToLower()).Distinct()) != String.Empty)
            {
                if (str.Contains(distinct[0]) == false)
                {
                    distinct.ToUpper();
                }
                return distinct[0].ToString();
            }
            else
            {
                return String.Empty;
            }
        }
    }
}