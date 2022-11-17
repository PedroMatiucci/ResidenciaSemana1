namespace exercicio1
{
    [Serializable]
    internal class InvalidNumberException : Exception
    {
        public InvalidNumberException(string? message) : base(message)
        {

            {
            }
        }
    }
}
