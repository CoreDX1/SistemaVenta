namespace POS.Infrastructure.Commons.Base.Request;

public class BaseFilterRequest : BasePaginationRequest
{
    public int? NumFilter { get; set; } = null; // Filter => va a procesar
    public string? TextFilter { get; set; } = null; // Filter => Texto
    public int? StateFilter { get; set; } = null; // Filter => Estado
    public string? StartDate { get; set; } = null; // Filter => Fecha inicio
    public string? EndDate { get; set; } = null; // Filter => Fecha final
    public bool? Download { get; set; } = false; // Filter => Descargar
}
