namespace TestKanban.Infrastructure.Models
{
    public interface IWorkItemTypeModel
    {
        int Id { get; set; }
        string Code { get; set; }
        string Label { get; set; }
    }
}