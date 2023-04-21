using System;

namespace Core {
    public static class IdGenerator {
        public static string Generate()=>Guid.NewGuid().ToString("N");
    }
}