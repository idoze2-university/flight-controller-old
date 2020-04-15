namespace FlightSimulatorApp.DataBase
{
    public static class Data
    {
        public const double PAD_RADIUS = 85;
        public const double SLIDER_INIT_AILERON = 5;
        public const double SLIDER_INIT_THROTTLE = 0;
        public const double SLIDER_MAX = 10;
        public const double SLIDER_MIN = 0;

        private static double asv = SLIDER_INIT_AILERON, av = 0;
        private static double tsv = SLIDER_INIT_THROTTLE, tv = 0;
        private static double x = 0, y = 0, r = 0, e = 0;

        public static double aileron_slider_value
        {
            get { return asv; }
            set
            {
                if (value > SLIDER_MAX) { asv = SLIDER_MAX; }
                else if (value < SLIDER_MIN) { asv = SLIDER_MIN; }
                else { asv = value; }
                av = (asv - SLIDER_INIT_AILERON) / SLIDER_INIT_AILERON;
            }
        }
        public static double throttle_slider_value
        {
            get { return tsv; }
            set
            {
                if (value > SLIDER_MAX) { tsv = SLIDER_MAX; }
                else if (value < SLIDER_MIN) { tsv = SLIDER_MIN; }
                else { tsv = value; }
                tv = tsv / SLIDER_MAX;
            }
        }

        public static double aileron_value
        {
            get
            {
                return av;
            }
            set
            {
                if (value >= 1)
                {
                    asv = SLIDER_MAX;
                }
                else if (value <= -1)
                {
                    asv = SLIDER_MIN;
                }
                else
                {
                    asv = (value * SLIDER_INIT_AILERON + SLIDER_INIT_AILERON);
                }
                av = (asv - SLIDER_INIT_AILERON) / SLIDER_INIT_AILERON;
            }
        }
        public static double throttle_value
        {
            get
            {
                return tv;
            }
            set
            {
                if (value >= 1)
                {
                    tsv = SLIDER_MAX;
                }
                else if (value <= 0)
                {
                    tsv = SLIDER_MIN;
                }
                else
                {
                    tsv = value * 10;
                }
                tv = tsv / SLIDER_MAX;
            }
        }

        public static double X
        {
            get { return x; }
            set
            {
                if (value > PAD_RADIUS) { x = PAD_RADIUS; }
                else if (value < PAD_RADIUS) { x = -PAD_RADIUS; }
                else { x = value; }
                r = x / PAD_RADIUS;
            }
        }
        public static double Y
        {
            get { return y; }
            set
            {
                if (value > PAD_RADIUS) { y = PAD_RADIUS; }
                else if (value < PAD_RADIUS) { y = -PAD_RADIUS; }
                else { y = value; }
                e = -y / PAD_RADIUS;
            }
        }

        public static double rudder
        {
            get { return r; }
            set
            {
                if (value > 1) { r = 1; }
                else if (value < -1) { r = -1; }
                else { r = value; }
                x = r * PAD_RADIUS;
            }
        }
        public static double elevator
        {
            get { return e; }
            set
            {
                if (value > 1) { e = 1; }
                else if (value < -1) { e = -1; }
                else { e = value; }
                y = -e * PAD_RADIUS;
            }
        }
    }
}
