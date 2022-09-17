namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный статический класс-фабрика для генерации целочисленных идентификаторов.
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// Cтатического поле-счетчик.
        /// </summary>
        private static int _count;
        
        /// <summary>
        /// Статическая фабрика, генерирующее целочисленный идентификатор.
        /// </summary>
        /// <returns></returns>
        public static int GetNextId()
        {
            return _count++;
        }
    }
}