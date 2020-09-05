using System;

namespace Store
{
    public class Product
    {
        public int Id { get; }// у каждой сущности должен быть свой уник идентификатор
        public string Title { get; }// описание свойства

        public Product(int id, string title) // инициализируем в конструкторе
        {
            Title = title;
            Id = id;
        }

    }
}
