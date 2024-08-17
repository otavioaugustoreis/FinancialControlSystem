namespace RepositoryPattern._2___Domain.Enum
{
    public class MonthsName 
    {
    public static  string ReturnMonths(int mes) =>
            mes switch
        {
            1 => Months.JANEIRO.ToString(),
            2 => Months.FEVEREIRO.ToString(),
            3 => Months.MARCO.ToString(),
            4 => Months.ABRIL.ToString(),
            5 => Months.MAIO.ToString(),
            6 => Months.JUNHO.ToString(),
            7 => Months.JULHO.ToString(),
            8 => Months.AGOSTO.ToString(),
            9 => Months.SETEMBRO.ToString(),
            10 => Months.OUTUBRO.ToString(),
            11 => Months.NOVEMBRO.ToString(),
            12 => Months.DEZEMBRO.ToString(),
            _ => "" 
        };
    }
}
