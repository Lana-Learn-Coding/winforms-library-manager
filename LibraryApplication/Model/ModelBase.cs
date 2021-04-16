using System;
using ReactiveUI;

namespace LibraryApplication.Model
{
    public abstract class Entity : ReactiveObject, IIdentified, IAuditable, IComparable
    {
        public abstract int? Id { get; set; }
        public abstract DateTime CreatedAt { get; set; }
        public abstract DateTime UpdatedAt { get; set; }

        public int CompareTo(object? obj)
        {
            return obj is null ? 1 : string.CompareOrdinal(ToString(), obj.ToString());
        }
    }

    public interface IIdentified
    {
        public int? Id { get; set; }
    }

    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }

        DateTime UpdatedAt { get; set; }
    }

    public interface INamed
    {
        string Name { get; set; }
    }
}