namespace TestKanban.Infrastructure.Models
{
    public interface IWorkItemTaskModel
    {
        int Id { get; set; }
        IWorkItemModel Parent { get; set; }
        string Description { get; set; }
    }
}