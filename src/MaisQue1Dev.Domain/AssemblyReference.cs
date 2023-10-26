using System.Reflection;

namespace MaisQue1Dev.Domain;

public static class AssemblyReference
{
    public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    public static readonly Assembly GetExecutingAssembly = Assembly.GetExecutingAssembly();
}