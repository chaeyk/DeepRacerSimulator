using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepRacer
{
    public partial class FrmMain : Form
    {
        private List<RPoint> _waypoints = new List<RPoint>()
        {
            new RPoint(2.909995283569139,0.6831924746239328),
            new RPoint(3.3199952311658905,0.6833390533713652),
            new RPoint(3.41999521838461,0.6833748042853732),
            new RPoint(3.6300023417267235,0.6834498837610459),
            new RPoint(4.189995119968753,0.6836500863232341),
            new RPoint(4.500002230529587,0.6837609167129147),
            new RPoint(4.549995073956144,0.6837787896136626),
            new RPoint(5.320002125723089,0.6840540742077795),
            new RPoint(5.420002112941809,0.6840898251217875),
            new RPoint(5.7800020669292005,0.684218528412216),
            new RPoint(6.289747858140073,0.6921400142174),
            new RPoint(6.460906484698166,0.7123063542781353),
            new RPoint(6.5136980596947165,0.7210294115664316),
            new RPoint(6.704287871536597,0.799598672280553),
            new RPoint(6.836281775656231,0.8817004790362547),
            new RPoint(6.991663362669656,1.0062653214908401),
            new RPoint(7.1142074641408275,1.1693225137564909),
            new RPoint(7.165830682349035,1.263426756737598),
            new RPoint(7.280019741788613,1.7628308313393968),
            new RPoint(7.272892208655982,1.8132370038722583),
            new RPoint(7.265960701310593,1.8622568749360433),
            new RPoint(7.1045747673751585,2.3014874894475916),
            new RPoint(7.011749008840918,2.419260292916218),
            new RPoint(6.727273712845888,2.6474924751765463),
            new RPoint(6.536921216759571,2.7266447610626687),
            new RPoint(6.079802178702642,2.773360773339069),
            new RPoint(5.919813651266964,2.772005974951175),
            new RPoint(5.719827991972368,2.7703124769663074),
            new RPoint(5.670000926947205,2.7698905365406308),
            new RPoint(5.200034627604903,2.765910816276192),
            new RPoint(5.049876033335467,2.7646392587170006),
            new RPoint(5.002030872389276,2.768980714618128),
            new RPoint(4.942709994269048,2.775327848322301),
            new RPoint(4.561340171137485,2.898322513024676),
            new RPoint(4.258533108743229,3.166955220685885),
            new RPoint(4.092728535429521,3.3703748558215287),
            new RPoint(4.001121969780925,3.482763638518189),
            new RPoint(3.774000078716213,3.761411273431655),
            new RPoint(3.6823935130676184,3.8738000561283137),
            new RPoint(3.5490587458571623,4.037383660336441),
            new RPoint(3.2758532950668884,4.333295323360169),
            new RPoint(3.1911463583891155,4.385684825652305),
            new RPoint(3.0954945192403103,4.435922305057415),
            new RPoint(2.9549738926202442,4.484413606024224),
            new RPoint(2.8089822299540046,4.500038654567632),
            new RPoint(2.8110045575773057,4.499832029419236),
            new RPoint(2.5003276964136627,4.498718163592657),
            new RPoint(2.249377566090162,4.491428972830993),
            new RPoint(1.990177178741659,4.483900142037221),
            new RPoint(1.7395172672798365,4.476619381080485),
            new RPoint(1.1871156114665855,4.391792930201858),
            new RPoint(1.1054389398706574,4.3402307341807065),
            new RPoint(0.7316196323127645,3.819658838269335),
            new RPoint(0.7080468873794841,3.5295953182618844),
            new RPoint(0.8747319412102282,2.7251244177375193),
            new RPoint(0.8863119620897287,2.6692358445815714),
            new RPoint(0.9180990438541362,2.5158220758940644),
            new RPoint(0.9380374746317692,2.4195933679559642),
            new RPoint(1.0212099341560652,2.0181787127447155),
            new RPoint(1.043063552869095,1.912706746772055),
            new RPoint(1.0936256517149223,1.6686792454688633),
            new RPoint(1.219724413480236,1.169889412099395),
            new RPoint(1.2404620134668318,1.1182110370035536),
            new RPoint(1.286611404297767,1.0270193376917442),
            new RPoint(1.3195344250237366,0.9895904728963364),
            new RPoint(1.3897426105955222,0.9097735962139227),
            new RPoint(1.4563853812178036,0.8435308547287804),
            new RPoint(1.4996428710531535,0.8193608401945228),
            new RPoint(2.0400025449490777,0.6828814442283201),
            new RPoint(2.7500024542019887,0.6831352757177762),
            new RPoint(2.909995283569139,0.6831924746239328)
        };
        private List<RPoint> _inner_border = new List<RPoint>()
        {
            new RPoint(2.909906444083587,0.9840787499610828),
            new RPoint(3.319906407704715,0.9842008783200711),
            new RPoint(3.4199063988318197,0.9842306657247023),
            new RPoint(3.6299123376796656,0.9842932210490071),
            new RPoint(4.189906330510524,0.9844600287403632),
            new RPoint(4.499912260485474,0.9845523714692992),
            new RPoint(4.5499062985681,0.9845672633970358),
            new RPoint(5.319912187727731,0.9847966281872758),
            new RPoint(5.419912178854835,0.984826415591907),
            new RPoint(5.779912146912412,0.9849336502485796),
            new RPoint(6.255308201425604,0.9887370185843034),
            new RPoint(6.42648361684787,1.0086153150902388),
            new RPoint(6.433070068359375,1.0093801879882813),
            new RPoint(6.58552837663102,1.0751901389624254),
            new RPoint(6.65414056181079,1.121153136506339),
            new RPoint(6.767670288085938,1.2075256347656251),
            new RPoint(6.865130542696974,1.345683363233008),
            new RPoint(6.883023391314907,1.3793610957984892),
            new RPoint(6.972432250976563,1.7477633666992187),
            new RPoint(6.969601773690491,1.7656646935058404),
            new RPoint(6.961888826195919,1.8144451569358484),
            new RPoint(6.863466114123764,2.106320230004854),
            new RPoint(6.769062197464956,2.2227494158821073),
            new RPoint(6.6006591796875,2.3618621826171875),
            new RPoint(6.431444702148438,2.436733856201172),
            new RPoint(6.082377876624694,2.462396818534284),
            new RPoint(5.922388813205334,2.4610740436881477),
            new RPoint(5.722402483931133,2.459420575130478),
            new RPoint(5.6725712484683495,2.45900857506364),
            new RPoint(5.20260337467398,2.4551229239531156),
            new RPoint(5.018619835463795,2.4566891383955527),
            new RPoint(4.9691856595622115,2.46197790460427),
            new RPoint(4.909864648480311,2.468324424054731),
            new RPoint(4.399026282932134,2.6360679163260246),
            new RPoint(4.018710641305418,2.9714793128627117),
            new RPoint(3.8529061314842683,3.1748989976067854),
            new RPoint(3.7612995949291355,3.287287815055975),
            new RPoint(3.534177795123867,3.5659355126652286),
            new RPoint(3.442571258568735,3.6783243301144166),
            new RPoint(3.30923654574253,3.8419079701360612),
            new RPoint(3.09720703125,4.081221618652344),
            new RPoint(3.028917153889106,4.123471202342913),
            new RPoint(2.994786471026911,4.144147305563019),
            new RPoint(2.8843350219726562,4.182270812988281),
            new RPoint(2.7788712303071925,4.192614571024957),
            new RPoint(2.7808141160514976,4.192424015198027),
            new RPoint(2.509406720502155,4.1882997283477925),
            new RPoint(2.258451665350191,4.180961642960754),
            new RPoint(1.9992580924048617,4.173382658074824),
            new RPoint(1.7485951938134034,4.166053115531388),
            new RPoint(1.314613037109375,4.11409423828125),
            new RPoint(1.2783204962571983,4.088884910007067),
            new RPoint(1.0248472113946108,3.7704349524329484),
            new RPoint(0.9966111768378945,3.59068638968341),
            new RPoint(1.1667667487821711,2.787071460950787),
            new RPoint(1.178615724180754,2.7311108279154777),
            new RPoint(1.211040078964814,2.5779762860297337),
            new RPoint(1.2314242341915527,2.4817054953489857),
            new RPoint(1.3163469413409712,2.080630441068597),
            new RPoint(1.338638685255012,1.9753504435221483),
            new RPoint(1.3902788553560892,1.7314629754755075),
            new RPoint(1.497822943058028,1.281588586929395),
            new RPoint(1.5185744153105296,1.2299234905909608),
            new RPoint(1.5296887207031251,1.2022521209716797),
            new RPoint(1.5434438985939147,1.186620425727402),
            new RPoint(1.613667277893416,1.1068169893088786),
            new RPoint(1.6322328186035158,1.0857186889648438),
            new RPoint(1.6445917267628223,1.0788141361524557),
            new RPoint(2.0399124787587044,0.9838196013153698),
            new RPoint(2.749912415761146,0.9840310918882519),
            new RPoint(2.909906444083587,0.9840787499610828)
        };
        private List<RPoint> _outer_border = new List<RPoint>()
        {
            new RPoint(2.9101200062595103,0.38230620783067915),
            new RPoint(3.320119934919921,0.38247723188186483),
            new RPoint(3.420119917520022,0.3825189450650809),
            new RPoint(3.630128223616876,0.3826065462298145),
            new RPoint(4.190119783540795,0.3828401365758443),
            new RPoint(4.50012807223775,0.382969450923794),
            new RPoint(4.550119720901156,0.38299030403542206),
            new RPoint(5.3201279295585735,0.3833114990261654),
            new RPoint(5.420127912158674,0.38335321220938146),
            new RPoint(5.780127849519036,0.38350337966895914),
            new RPoint(6.324972631375165,0.3956832604952143),
            new RPoint(6.496120858284972,0.4160202072156111),
            new RPoint(6.62472364224327,0.44473185107344176),
            new RPoint(6.815966218031551,0.521642101758542),
            new RPoint(7.017519684834686,0.6415111643040204),
            new RPoint(7.229499454034008,0.8217965373170768),
            new RPoint(7.354308823693938,0.9825323713128955),
            new RPoint(7.447931440559386,1.1453875219327774),
            new RPoint(7.584628865863982,1.8031173114342751),
            new RPoint(7.577929620223677,1.8535557187007277),
            new RPoint(7.571403728787527,1.90268894767995),
            new RPoint(7.350201669529235,2.492043640838347),
            new RPoint(7.258218658533806,2.610503855324811),
            new RPoint(6.843319429832621,2.9366420720078783),
            new RPoint(6.652076861387874,3.0135523418410606),
            new RPoint(6.077102317373509,3.0843225367722926),
            new RPoint(5.917114336078783,3.0829358686812904),
            new RPoint(5.717129359460375,3.081202533567537),
            new RPoint(5.667306448817149,3.080770702127258),
            new RPoint(5.197341753763893,3.076697364609938),
            new RPoint(5.047179687788711,3.0753958609364638),
            new RPoint(5.034886471281728,3.0759817113964028),
            new RPoint(4.97556588304942,3.082330184103404),
            new RPoint(4.723655995002148,3.1605758734283604),
            new RPoint(4.498355317486535,3.3624310927965775),
            new RPoint(4.3325507156607355,3.5658507056549404),
            new RPoint(4.240944136947374,3.6782394727455503),
            new RPoint(4.0138222049015155,3.9568870795046953),
            new RPoint(3.922215626188155,4.069275846595304),
            new RPoint(3.7888808345557994,4.232859434720925),
            new RPoint(3.4380291650003363,4.595552001126502),
            new RPoint(3.353319122878281,4.64793530145161),
            new RPoint(3.1961735515503995,4.727704914445076),
            new RPoint(3.055651529170767,4.776192024941823),
            new RPoint(2.840968530687481,4.80720241399628),
            new RPoint(2.84303014895641,4.80698759310109),
            new RPoint(2.4913683324088596,4.809142846799084),
            new RPoint(2.2404230806588203,4.8019019048214995),
            new RPoint(1.981215987743099,4.794422570158293),
            new RPoint(1.7305590426333723,4.787189947173157),
            new RPoint(1.1133976663098506,4.68342738185746),
            new RPoint(0.9132873376602105,4.575866464388443),
            new RPoint(0.4396815695265954,3.8869828266056468),
            new RPoint(0.4183040104700681,3.4707944950583007),
            new RPoint(0.5817439759375306,2.665552102434232),
            new RPoint(0.5930735980115257,2.6097328787804766),
            new RPoint(0.6242638438593316,2.4560635597666995),
            new RPoint(0.6437866949569175,2.3598776159940114),
            new RPoint(0.7253233176311822,1.9581598051701847),
            new RPoint(0.7467666116515489,1.8525121483482125),
            new RPoint(0.7963216533547308,1.6083624372691325),
            new RPoint(0.9415723136978997,1.058316414523293),
            new RPoint(0.962303954307788,1.006632340237715),
            new RPoint(1.0626459793805891,0.8300487672594938),
            new RPoint(1.095566151040184,0.7926169730979473),
            new RPoint(1.1657678278926826,0.712794342009927),
            new RPoint(1.3114141412298634,0.5840889274264379),
            new RPoint(1.3546711732192105,0.5599177517631669),
            new RPoint(2.040128500275279,0.3819433066166796),
            new RPoint(2.7501283767359923,0.38223947021751337),
            new RPoint(2.9101200062595103,0.38230620783067915)
        };

        private DeepRacerClient _client;
        private Task _connectTask;
        private CancellationTokenSource _closingCts = new CancellationTokenSource();

        private Size _carSize = new Size(25 * RPoint.SCALE, 18  * RPoint.SCALE);
        private Point _carPosition;
        private int _closestWaypoint = -1;
        private double _distanceFromCenter;
        private bool _isLeftOfCenter;
        private const double _trackWidth = 0.6017558857057772;
        private bool _allWheelsOnTrack;
        private double _trackDirection;
        private double _directionDiff;

        private Setting _setting = new Setting();

        private double _maxReward = 1.0;

        private List<Label> rewardNameLabels;
        private List<ProgressBar> rewardValueProgressBars;
        private List<Label> rewardValueLabels;

        public FrmMain()
        {
            InitializeComponent();

            rewardNameLabels = new List<Label>();
            rewardNameLabels.Add(lblReward1Name);
            rewardNameLabels.Add(lblReward2Name);
            rewardNameLabels.Add(lblReward3Name);
            rewardValueProgressBars = new List<ProgressBar>();
            rewardValueProgressBars.Add(pbReward1);
            rewardValueProgressBars.Add(pbReward2);
            rewardValueProgressBars.Add(pbReward3);
            rewardValueLabels = new List<Label>();
            rewardValueLabels.Add(lblReward1);
            rewardValueLabels.Add(lblReward2);
            rewardValueLabels.Add(lblReward3);

            tbSteer.Minimum = -(_setting.SteerSteps / 2);
            tbSteer.Maximum = -tbSteer.Minimum;
            tbSteer.Value = 0;
            tbThrottle.Maximum = _setting.SpeedStep;
            tbThrottle.Value = tbThrottle.Maximum;
            tbHeading.Value = 0;

            setCarPosition(_waypoints[0].toPoint(), false);
            setRewardValues(new RewardResponse());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _connectTask = connectLoopAsync(_closingCts.Token);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _closingCts.Cancel();
        }

        private async Task connectLoopAsync(CancellationToken ct)
        {
            var addr = IPAddress.Loopback;
            var port = 11111;

            while (!ct.IsCancellationRequested)
            {
                try
                {
                    _client = new DeepRacerClient();
                    Console.WriteLine("Try Connecting...");
                    await _client.ConnectAsync(addr, port, ct);
                    Console.WriteLine("Connected.");

                    await _client.SendInitializingDataAsync(
                        new InitializingData()
                        {
                            waypoints = _waypoints
                        });

                    while (!ct.IsCancellationRequested)
                    {
                        var reward = await _client.GetRewardAsync(createRewardRequest());
                        setRewardValues(reward);
                        await Task.Delay(TimeSpan.FromMilliseconds(200), ct);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Socket error: {e}");
                }
                await Task.Delay(TimeSpan.FromSeconds(1), ct);
            }
        }

        private RewardRequest createRewardRequest()
        {
            var request = new RewardRequest();
            request.all_wheels_on_track = _allWheelsOnTrack;
            request.x = RPoint.ToRacerX(_carPosition.X);
            request.y = RPoint.ToRacerY(_carPosition.Y);
            request.distance_from_center = _distanceFromCenter;
            request.is_left_of_center = _isLeftOfCenter;
            request.heading = tbHeading.Value;
            request.progress = tbProgress.Value;
            request.steps = 5000; // TODO
            request.speed = tbThrottle.Value / (double)tbThrottle.Maximum;
            request.steering_angle = (double)_setting.MaxSteer * tbSteer.Value / tbSteer.Maximum;
            request.track_width = _trackWidth;
            request.closest_waypoints = new int[] { _closestWaypoint, _closestWaypoint + 1 };
            return request;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            drawLine(_waypoints, graphics);
            drawLine(_inner_border, graphics);
            drawLine(_outer_border, graphics);

            drawCar(graphics);

            drawWaypoint(graphics);
        }

        private void drawLine(List<RPoint> points, Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            using (var brush = new SolidBrush(Color.Black))
            {
                var bp = Point.Empty;
                foreach (var rp in points)
                {
                    var p = rp.toPoint();
                    if (!bp.IsEmpty)
                    {
                        graphics.DrawLine(pen, bp, p);
                    }
                    bp = p;
                }
            }
        }

        private void drawWaypoint(Graphics graphics)
        {
            using (var pen = new Pen(Color.Black))
            using (var normalBrush = new SolidBrush(Color.Black))
            using (var startBrush = new SolidBrush(Color.Red))
            using (var closeBrush = new SolidBrush(Color.Blue))
            {
                var circleSize = new Size(6, 6);
                var circleSizeHalf = new Size(circleSize.Width / 2, circleSize.Height / 2);

                for (var i = 0; i < _waypoints.Count; i++)
                {
                    var rp = _waypoints[i];
                    var p = rp.toPoint();

                    Brush brush;
                    if (i == _closestWaypoint || i == _closestWaypoint + 1 || (_closestWaypoint == i - _waypoints.Count + 1))
                    {
                        brush = closeBrush;
                    }
                    else if (i == 0 || i == _waypoints.Count - 1)
                    {
                        brush = startBrush;
                    }
                    else
                    {
                        brush = normalBrush;
                    }

                    graphics.FillEllipse(brush, new Rectangle(p - circleSizeHalf, circleSize));
                }
            }
        }

        private void drawCar(Graphics graphics)
        {
            if (_carPosition.IsEmpty)
            {
                return;
            }

            using (var brush = new SolidBrush(Color.Yellow))
            using (var frontBrush = new SolidBrush(Color.Red))
            using (var sidePen = new Pen(Color.Blue))
            using (var outBrush = new SolidBrush(Color.Gray))
            {
                graphics.TranslateTransform(_carPosition.X, _carPosition.Y);
                graphics.RotateTransform(-tbHeading.Value);

                var carHalfSize = new Size(_carSize.Width, _carSize.Height / 2);
                graphics.FillRectangle(_allWheelsOnTrack ? brush : outBrush, new Rectangle(new Point(-_carSize.Width, -_carSize.Height / 2), _carSize));

                // 차의 앞부분을 표시
                graphics.FillRectangle(frontBrush, new Rectangle(-3, -_carSize.Height / 2, 3, _carSize.Height));

                // 옆구리에 중앙선 방향을 표시
                var y = _carSize.Height / 2 * (_isLeftOfCenter ? -1 : 1);
                graphics.DrawLine(sidePen, new Point(-_carSize.Width, y), new Point(-1, y));
                graphics.FillRectangle(frontBrush, new Rectangle(-_carSize.Width, _carSize.Height / 2 * (_isLeftOfCenter ? -1 : 1), _carSize.Width, 2));

                graphics.ResetTransform();
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                setCarPosition(e.Location, true);
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                setCarPosition(e.Location, true);
            }
        }

        // setCarPosition()으로 재진입하지 않도록 한다.
        private bool _settingCarPosition = false;

        private void setCarPosition(Point newPosition, bool maintainDirectionDiff)
        {
            if (_settingCarPosition)
                return;

            _settingCarPosition = true;
            try
            {
                Point oldPosition = _carPosition;
                _carPosition = newPosition;

                int oldClosestWaypoint = _closestWaypoint;
                RPoint newRPosition = RPoint.From(newPosition);
                _closestWaypoint = findClosestWaypointPrevIndex(newRPosition, _waypoints);

                _distanceFromCenter = newRPosition.DistanceToLine(_waypoints[_closestWaypoint], _waypoints[_closestWaypoint + 1]);
                _isLeftOfCenter = newRPosition.IsLeftOfLine(_waypoints[_closestWaypoint], _waypoints[_closestWaypoint + 1]);
                _allWheelsOnTrack = _distanceFromCenter < (_trackWidth * 0.45);
                _trackDirection = _waypoints[_closestWaypoint].GetAngle(_waypoints[_closestWaypoint + 1]);
                if (maintainDirectionDiff)
                {
                    tbHeading.Value = (int)getAngleDiff(_trackDirection + _directionDiff, 0);
                }
                else
                {
                    _directionDiff = getAngleDiff(_trackDirection, tbHeading.Value);
                }

                // 차가 회전을 하니 최대 변의 길이 * 2.5 해서 다시 그려야 한다
                int max = Math.Max(_carSize.Width, _carSize.Height);
                int len = (int)(max * 2.5);

                Size drawSize = new Size(len, len);
                Size drawHalfSize = new Size(drawSize.Width / 2, drawSize.Height / 2);

                Region region = new Region(new Rectangle(newPosition - drawHalfSize, drawSize));
                if (!oldPosition.IsEmpty)
                {
                    region.Union(new Rectangle(oldPosition - drawHalfSize, drawSize));
                }

                // 이전의 closest waypoint 표시는 지워야 한다.
                if (oldClosestWaypoint >= 0)
                {
                    Size wpSize = new Size(6, 6);
                    Size wpHalfSize = new Size(wpSize.Width / 2, wpSize.Height / 2);

                    Point wp1 = _waypoints[oldClosestWaypoint].toPoint();
                    region.Union(new Rectangle(wp1 - wpHalfSize, wpSize));

                    Point wp2 = _waypoints[oldClosestWaypoint + 1].toPoint();
                    region.Union(new Rectangle(wp2 - wpHalfSize, wpSize));
                }

                canvas.Invalidate(region);

                setPositionLabels();
            }
            finally
            {
                _settingCarPosition = false;
            }
        }

        private double getAngleDiff(double angle1, double angle2)
        {
            double diff = angle1 - angle2;
            if (diff >= 180)
                diff -= 360;
            else if (diff <= -180)
                diff += 360;
            return diff;
        }

        private void setPositionLabels()
        {
            // 현재 위치를 label에 출력
            RPoint rpos = RPoint.From(_carPosition);
            lblPosition.Text = String.Format("X: {0,0:f2}, Y: {1,0:f2}", rpos.X, rpos.Y);

            lblClosestWp.Text = $"Closest Waypoint: {_closestWaypoint}";

            lblAngle.Text = String.Format("Track Direction: {0,0:f2}, DirectionDiff: {1,0:f2}",
                _trackDirection, _directionDiff);

            lblDistanceFromCenter.Text = String.Format("Distance from center: {0,0:f3}", _distanceFromCenter);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            setControlLabels();
            setCarPosition(_carPosition, false);
        }

        private void setControlLabels()
        {
            lbThrottle.Text = String.Format("{0,0:f2}", (double)_setting.MaxSpeed * tbThrottle.Value / tbThrottle.Maximum);
            lbSteer.Text = String.Format("{0,0:f2}", (double)_setting.MaxSteer * tbSteer.Value / tbSteer.Maximum);
            lbHeading.Text = tbHeading.Value.ToString();
            lblProgress.Text = tbProgress.Value.ToString();
        }

        private void setRewardValues(RewardResponse response)
        {
            if (response.reward > _maxReward)
                _maxReward = response.reward;
            pbTotalReward.Value = Math.Min(100, (int)(response.reward * 100 / _maxReward));
            lblTotalReward.Text = response.reward.ToString("f6");

            if (response.ext_rewards == null)
                return;

            var i = 0;
            foreach (var name in response.ext_rewards.Keys)
            {
                if (i >= rewardNameLabels.Count)
                    break;

                var reward = response.ext_rewards[name];
                if (reward > _maxReward)
                    _maxReward = reward;
                var progress = Math.Min(100, (int)(reward * 100 / _maxReward));
                rewardNameLabels[i].Text = name;
                rewardNameLabels[i].Visible = true;
                rewardValueProgressBars[i].Value = progress;
                rewardValueProgressBars[i].Visible = true;
                rewardValueLabels[i].Text = reward.ToString("f6");
                rewardValueLabels[i].Visible = true;
                i++;
            }

            while (i < rewardNameLabels.Count)
            {
                rewardNameLabels[i].Visible = false;
                rewardValueProgressBars[i].Visible = false;
                rewardValueLabels[i].Visible = false;
                i++;
            }
        }

        private int findClosestWaypointPrevIndex(RPoint pt, List<RPoint> waypoints)
        {
            var index = -1;
            for (var i = 0; i < waypoints.Count - 1; i++)
            {
                RPoint prev = waypoints[i];
                RPoint next = waypoints[i + 1];

                double angle = prev.GetAngle(next);

                RPoint rotatedNext = RPoint.Rotate(prev, next, -angle);
                RPoint rotatedPt = RPoint.Rotate(prev, pt, -angle);
                if (rotatedPt.X <= rotatedNext.X)
                {
                    if (index < 0 || pt.DistanceTo(next) < pt.DistanceTo(waypoints[index + 1]))
                    {
                        index = i;
                    }
                }
            }

            if (index == -1)
                throw new Exception($"cannot find closest waypoint of {pt}");

            return index;
        }

        private void btnResetScale_Click(object sender, EventArgs e)
        {
            _maxReward = 1;
        }
    }
}
