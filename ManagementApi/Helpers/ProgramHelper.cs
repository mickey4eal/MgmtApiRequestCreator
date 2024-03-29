﻿namespace ManagementApi.Helpers
{
    using Constants;
    using Resources;

    public static class ProgramHelper
    {
        public static bool? HasConfirmedExecutionRoute(string? consoleInput)
        {
            bool? hasConfirmedExecutionRoute = null;

            if (IsBooleanNull(hasConfirmedExecutionRoute) && (consoleInput?.ToLower() is Strings.S or Strings.SALE))
            {
                hasConfirmedExecutionRoute = true;
            }

            if (IsBooleanNull(hasConfirmedExecutionRoute) && (consoleInput?.ToLower() is Strings.L or Strings.LOT))
            {
                hasConfirmedExecutionRoute = false;
            }

            if (IsBooleanNull(hasConfirmedExecutionRoute))
            {
                Console.WriteLine(ApiRequests.StandardCommandPromptMsg);
            }

            return hasConfirmedExecutionRoute;
        }

        public static bool ShouldProgramRun(string? consoleInput) => !(consoleInput?.ToLower() is Strings.EX or Strings.EXIT);

        public static bool IsBooleanNull(bool? value) => value == null;
    }
}