﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;
using TechTalk.SpecFlow.VsIntegration.Tracing.OutputWindow;

namespace TechTalk.SpecFlow.VsIntegration.Tracing
{
    public static class OutputWindowDefinitions
    {
        public const string SpecFlowOutputWindowName = "SpecFlow";
        [Export]
        [Name(SpecFlowOutputWindowName)]
        internal static OutputWindowDefinition SpecFlowOutputWindowDefinition = null;

        public const string SpecRunOutputWindowName = "SpecRun";
        [Export]
        [Name(SpecRunOutputWindowName)]
        internal static OutputWindowDefinition SpecRunOutputWindowDefinition = null;
    }
}
