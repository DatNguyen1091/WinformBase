namespace BusinessLogic.Entities.Base
{
    public interface IEntity<TId> : IEntity
    {
        TId Id { get; set; }
    }

    public interface IEntity
    {
    }
}