namespace exercicio1
{
    [Serializable]
    internal class ImpossibleTriangleExeption : Exception
    {
        public ImpossibleTriangleExeption(string? message) : base(message)
        {

            {
            }
        }
    }
}