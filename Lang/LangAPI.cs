using System.Collections.Generic;

namespace Polaris.Lang
{
    /// <summary>PolarisLang 的统一公开入口：解析文档、注册文案与按当前语言解析。</summary>
    public static class LangAPI
    {
        public static PlangDocument Load(string path) => PlangDocument.Load(path);

        public static PlangDocument Parse(string xml) => PlangDocument.Parse(xml);

        public static void Register(string key, string neutralValue, IReadOnlyDictionary<string, string> values) =>
            PlangRuntime.Register(key, neutralValue, values);

        public static string Get(string key) => PlangRuntime.Get(key);
    }
}
