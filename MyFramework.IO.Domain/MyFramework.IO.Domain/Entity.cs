using System;

namespace MyFramework.IO.Domain
{
    public abstract class Entity
    {
        private const int saltHashNumber = 909;

        //TODO: Create Validations

        public Guid Id { get; protected set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            var entitty = obj as Entity;

            if (ReferenceEquals(this, entitty))
                return true;

            if (ReferenceEquals(null, entitty))
                return false;

            return Id.Equals(entitty.Id);
        }

        public static bool operator ==(Entity entityA, Entity entityB)
        {
            if (ReferenceEquals(entityA, null) && ReferenceEquals(entityB, null))
                return true;

            if (ReferenceEquals(entityA, null) || ReferenceEquals(entityB, null))
                return false;

            return entityA.Equals(entityB);
        }

        public static bool operator !=(Entity entityA, Entity entityB)
        {
            return !(entityA == entityB);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * saltHashNumber) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name}[Id={Id}]";
        }
    }
}
