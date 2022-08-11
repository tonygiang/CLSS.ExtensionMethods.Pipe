// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class PipeExtension
  {
#if NETSTANDARD2_0_OR_GREATER
    /// <inheritdoc cref="Pipe{T, TResult}(T, Func{T, TResult})"/>
    public static TResult Pipe<T, TResult>(this T arg, Converter<T, TResult> func)
    { return func(arg); }

    /// <inheritdoc cref="PipeKeep{T, TResult}(T, Func{T, TResult})"/>
    public static T PipeKeep<T, TResult>(this T arg, Converter<T, TResult> func)
    { func(arg); return arg; }
#endif

    /// <inheritdoc cref="Pipe{T, TResult}(T, Func{T, TResult})"/>
    public static bool Pipe<T, TResult>(this T arg, Predicate<T> func)
    { return func(arg); }

    /// <inheritdoc cref="PipeKeep{T, TResult}(T, Func{T, TResult})"/>
    public static T PipeKeep<T, TResult>(this T arg, Predicate<T> func)
    { func(arg); return arg; }
  }
}
