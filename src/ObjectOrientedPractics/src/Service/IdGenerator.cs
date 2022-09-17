namespace ObjectOrientedPractics.Service
{
    public class IdGenerator
    {
        private static int _count;
        
        public static int GetNextId()
        {
            return _count++;
        }
    }
}