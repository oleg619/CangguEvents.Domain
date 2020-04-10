﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CangguEvents.Domain.Extensions
{
    public static class TaskExtensions
    {
        public static Task<T[]> WhenAll<T>(this IEnumerable<Task<T>> tasks)
        {
            return Task.WhenAll(tasks);
        }

        public static Task WhenAll(this IEnumerable<Task> tasks)
        {
            return Task.WhenAll(tasks);
        }
    }
}