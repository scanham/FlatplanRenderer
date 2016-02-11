using Microsoft.AspNet.Mvc.Razor.Precompilation;
using Microsoft.Dnx.Compilation.CSharp;

namespace FlatplanRenderer
{
    public class RazorPreCompilation : RazorPreCompileModule
    {
        protected override bool EnablePreCompilation(BeforeCompileContext context) => true;
    }
}
