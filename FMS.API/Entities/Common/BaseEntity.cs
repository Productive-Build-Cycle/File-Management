namespace FMS.API.Entities.Common;

public class BaseEntity
{
    public int Id { get; set; }

    public int CreatedByUserId { get; set; }
    public int? UpdatedByUserId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; private set; }
    public DateTime? DeletedAt { get; private set; }
}