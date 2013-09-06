

using System;
using ProtoCore;
using ProtoCore.Utils;

namespace ProtoScript
{
    public static class CompilerUtils
    {
        public static ProtoLanguage.CompileStateTracker BuildDefaultCompilerState()
        {
            ProtoLanguage.CompileOptions options = new ProtoLanguage.CompileOptions();

            ProtoLanguage.CompileStateTracker compileState = new ProtoLanguage.CompileStateTracker(options);

            compileState.Executives.Add(ProtoCore.Language.kAssociative, new ProtoAssociative.Executive());
            compileState.Executives.Add(ProtoCore.Language.kImperative, new ProtoImperative.Executive());

            return compileState;
        }
    }
}
