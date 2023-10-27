using Core;

namespace Core
{
    using System;

    public partial struct ContributeStringSafe
    {
        public String StringValue { get; set; }
        public String StringValueSafe { get; set; }

        public static ContributeStringSafe Simple(String item_STRING)
        {
            ContributeStringSafe safeResult = default;

            String stringValue, stringValueSafe;

            stringValue = item_STRING;

            stringValueSafe = Contribute.SolidString(stringValue);

            ContributeStringSafe safe;

            safe = new ContributeStringSafe();

            safe.StringValue = stringValue;

            safe.StringValueSafe = stringValueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
