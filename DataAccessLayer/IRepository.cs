namespace DataAccessLayer
{
    /// <summary>
    /// Интерфейс репозитория для работы с данными.
    /// </summary>
    /// <typeparam name="T">Тип сущности.</typeparam>
    public interface IRepository<T> : IDisposable where T : class
    {
        // Добавление нового объекта
        void Add(T entity);

        // Удаление объекта по идентификатору
        void Delete(int id);

        // Получение всех объектов
        IEnumerable<T> ReadAll();

        // Получение объекта по идентификатору
        T ReadById(int id);

        // Обновление объекта
        void Update(T entity);
    }
}
