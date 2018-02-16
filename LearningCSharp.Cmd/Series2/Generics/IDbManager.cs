namespace LearningCSharp.Cmd.Series2.Generics
{
    public interface IDbManager<TModel>
    {
        TModel Add(TModel item);
        bool Delete(int id);
        TModel Update(TModel item);
    }
}