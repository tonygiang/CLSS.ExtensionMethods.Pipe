// A part of the C# Language Syntactic Sugar suite.

using System;

namespace CLSS
{
  public static partial class PipeExtension
  {
    /// <summary>
    /// Takes an object, passes it as an argument to the specified action.
    /// </summary>
    /// <typeparam name="T">The type of <paramref name="arg"/>.</typeparam>
    /// <param name="arg">The object to be used as the argument to
    /// <paramref name="action"/>.</param>
    /// <param name="action">The action to be executed with
    /// <paramref name="arg"/> as the argument.</param>
    /// <returns>The source object.</returns>
    public static T Pipe<T>(this T arg, Action<T> action)
    { action(arg); return arg; }

    /// <summary>
    /// Takes an object, passes it as an argument to the specified function,
    /// returns the result.
    /// </summary>
    /// <typeparam name="T">The type of <paramref name="arg"/>.</typeparam>
    /// <typeparam name="TResult">The return type of <paramref name="func"/>.
    /// </typeparam>
    /// <param name="arg">The object to be used as the argument to
    /// <paramref name="func"/>.</param>
    /// <param name="func">The function to be executed with
    /// <paramref name="arg"/> as the argument.</param>
    /// <returns>The result of calling the specified function.</returns>
    public static TResult Pipe<T, TResult>(this T arg, Func<T, TResult> func)
    { return func(arg); }

    /// <summary>
    /// Takes an object, passes it as an argument to the specified action,
    /// returns the source object.
    /// </summary>
    /// <typeparam name="T">The type of <paramref name="arg"/>.</typeparam>
    /// <typeparam name="TResult">The return type of <paramref name="func"/>.
    /// </typeparam>
    /// <param name="arg">The object to be used as the argument to
    /// <paramref name="func"/>.</param>
    /// <param name="func">The function to be executed with
    /// <paramref name="arg"/> as the argument.</param>
    /// <returns>The result of calling the specified function.</returns>
    public static T PipeKeep<T, TResult>(this T arg, Func<T, TResult> func)
    { func(arg); return arg; }
  }
}
