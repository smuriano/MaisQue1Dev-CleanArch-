using System.Reflection;

namespace MaisQue1Dev.Application;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    public static readonly Assembly GetExecutingAssembly = Assembly.GetExecutingAssembly();
}