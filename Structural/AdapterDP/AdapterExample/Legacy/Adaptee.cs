namespace AdapterExample.Legacy
{
    public class Adaptee
    {
        public int GetData()
        {
            return 23;
        }

        public int[] GetInformations()
        {
            int [] value = {14, 20, 21};
            return value;
        }
    }
}
