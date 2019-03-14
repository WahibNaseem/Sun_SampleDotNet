using System;

namespace SampleDotNet.Core.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; } 
        public DateTime Created { get; set; }
    }
}