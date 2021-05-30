namespace TestKanban.Infrastructure.Models
{
    public interface IWorkItemStatusModel
    {
        int Id { get; set; }
        string Code { get; set; }
        string Label { get; set; }
    }
}