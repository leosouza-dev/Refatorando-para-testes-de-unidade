using System;

namespace Store.Domain.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}