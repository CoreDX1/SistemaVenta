namespace POS.Infrastructure.Commons.Base;
    // Devolver los registros de la base de datos
    public class BaseEntityReponse<T>
    {
        public int? TotalRecords { get; set; }
        public List<T>? Items { get; set; }
    }