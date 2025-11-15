namespace SQLQueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var query = new QueryBuilder()
                .Select("Name, Age").From("users").Build();
            query.ToSql();
            
        }
    }
}
