using System;
using System.Collections.Generic;

namespace BuildYourOwnLinq
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> InfiniteConstant(int value)
        {
            while (true)
            {
                yield return value;
            }
        }

        public static IEnumerable<int> Range(int start, int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return start + i;
            }
        }

        public static int Count<T>(this IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public static int Count<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public static List<T> ToList<T>(this IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }
        
        public static bool Any<T>(this IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public static bool Any<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public static bool All<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Take<T>(this IEnumerable<T> items, int count)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Skip<T>(this IEnumerable<T> items, int count)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<U> Select<T, U>(this IEnumerable<T> items, Func<T, U> selector)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> items, TAccumulate seed,
            Func<TAccumulate, TSource, TAccumulate> reducer)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<(T1, T2)> Zip<T1, T2>(this IEnumerable<T1> items1, IEnumerable<T2> items2)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<TResult> Zip<T1, T2, TResult>(this IEnumerable<T1> items1, IEnumerable<T2> items2, Func<T1, T2, TResult> resultSelector)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> items1, IEnumerable<T> items2)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<U> SelectMany<T, U>(this IEnumerable<T> items, Func<T, IEnumerable<U>> selector)
        {
            throw new NotImplementedException();
        }
    }
}
