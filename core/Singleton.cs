namespace Osobytes.Core
{
    public class BaseSingleton<T>
        where T : BaseSingleton<T>, new()
    {
        private static T singleton;
        public static T Singleton => singleton ??= new T();
    }
}