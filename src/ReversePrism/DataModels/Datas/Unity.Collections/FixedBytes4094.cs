using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 020 Offset0016                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 030 Offset0032                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 040 Offset0048                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 050 Offset0064                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 060 Offset0080                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 070 Offset0096                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 080 Offset0112                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 090 Offset0128                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0A0 Offset0144                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0B0 Offset0160                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0C0 Offset0176                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0D0 Offset0192                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0E0 Offset0208                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 0F0 Offset0224                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 100 Offset0240                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 110 Offset0256                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 120 Offset0272                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 130 Offset0288                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 140 Offset0304                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 150 Offset0320                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 160 Offset0336                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 170 Offset0352                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 180 Offset0368                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 190 Offset0384                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1A0 Offset0400                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1B0 Offset0416                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1C0 Offset0432                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1D0 Offset0448                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1E0 Offset0464                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1F0 Offset0480                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 200 Offset0496                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 210 Offset0512                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 220 Offset0528                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 230 Offset0544                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 240 Offset0560                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 250 Offset0576                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 260 Offset0592                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 270 Offset0608                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 280 Offset0624                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 290 Offset0640                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2A0 Offset0656                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2B0 Offset0672                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2C0 Offset0688                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2D0 Offset0704                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2E0 Offset0720                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 2F0 Offset0736                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 300 Offset0752                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 310 Offset0768                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 320 Offset0784                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 330 Offset0800                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 340 Offset0816                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 350 Offset0832                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 360 Offset0848                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 370 Offset0864                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 380 Offset0880                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 390 Offset0896                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3A0 Offset0912                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3B0 Offset0928                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3C0 Offset0944                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3D0 Offset0960                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3E0 Offset0976                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 3F0 Offset0992                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 400 Offset1008                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 410 Offset1024                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 420 Offset1040                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 430 Offset1056                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 440 Offset1072                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 450 Offset1088                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 460 Offset1104                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 470 Offset1120                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 480 Offset1136                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 490 Offset1152                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4A0 Offset1168                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4B0 Offset1184                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4C0 Offset1200                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4D0 Offset1216                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4E0 Offset1232                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 4F0 Offset1248                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 500 Offset1264                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 510 Offset1280                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 520 Offset1296                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 530 Offset1312                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 540 Offset1328                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 550 Offset1344                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 560 Offset1360                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 570 Offset1376                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 580 Offset1392                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 590 Offset1408                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5A0 Offset1424                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5B0 Offset1440                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5C0 Offset1456                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5D0 Offset1472                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5E0 Offset1488                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 5F0 Offset1504                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 600 Offset1520                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 610 Offset1536                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 620 Offset1552                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 630 Offset1568                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 640 Offset1584                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 650 Offset1600                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 660 Offset1616                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 670 Offset1632                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 680 Offset1648                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 690 Offset1664                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6A0 Offset1680                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6B0 Offset1696                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6C0 Offset1712                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6D0 Offset1728                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6E0 Offset1744                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 6F0 Offset1760                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 700 Offset1776                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 710 Offset1792                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 720 Offset1808                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 730 Offset1824                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 740 Offset1840                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 750 Offset1856                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 760 Offset1872                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 770 Offset1888                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 780 Offset1904                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 790 Offset1920                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7A0 Offset1936                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7B0 Offset1952                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7C0 Offset1968                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7D0 Offset1984                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7E0 Offset2000                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 7F0 Offset2016                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 800 Offset2032                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 810 Offset2048                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 820 Offset2064                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 830 Offset2080                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 840 Offset2096                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 850 Offset2112                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 860 Offset2128                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 870 Offset2144                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 880 Offset2160                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 890 Offset2176                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8A0 Offset2192                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8B0 Offset2208                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8C0 Offset2224                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8D0 Offset2240                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8E0 Offset2256                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 8F0 Offset2272                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 900 Offset2288                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 910 Offset2304                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 920 Offset2320                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 930 Offset2336                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 940 Offset2352                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 950 Offset2368                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 960 Offset2384                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 970 Offset2400                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 980 Offset2416                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 990 Offset2432                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9A0 Offset2448                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9B0 Offset2464                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9C0 Offset2480                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9D0 Offset2496                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9E0 Offset2512                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 9F0 Offset2528                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A00 Offset2544                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A10 Offset2560                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A20 Offset2576                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A30 Offset2592                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A40 Offset2608                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A50 Offset2624                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A60 Offset2640                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A70 Offset2656                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A80 Offset2672                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // A90 Offset2688                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AA0 Offset2704                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AB0 Offset2720                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AC0 Offset2736                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AD0 Offset2752                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AE0 Offset2768                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // AF0 Offset2784                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B00 Offset2800                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B10 Offset2816                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B20 Offset2832                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B30 Offset2848                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B40 Offset2864                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B50 Offset2880                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B60 Offset2896                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B70 Offset2912                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B80 Offset2928                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // B90 Offset2944                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BA0 Offset2960                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BB0 Offset2976                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BC0 Offset2992                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BD0 Offset3008                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BE0 Offset3024                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // BF0 Offset3040                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C00 Offset3056                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C10 Offset3072                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C20 Offset3088                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C30 Offset3104                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C40 Offset3120                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C50 Offset3136                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C60 Offset3152                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C70 Offset3168                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C80 Offset3184                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // C90 Offset3200                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CA0 Offset3216                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CB0 Offset3232                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CC0 Offset3248                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CD0 Offset3264                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CE0 Offset3280                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // CF0 Offset3296                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D00 Offset3312                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D10 Offset3328                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D20 Offset3344                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D30 Offset3360                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D40 Offset3376                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D50 Offset3392                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D60 Offset3408                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D70 Offset3424                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D80 Offset3440                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // D90 Offset3456                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DA0 Offset3472                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DB0 Offset3488                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DC0 Offset3504                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DD0 Offset3520                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DE0 Offset3536                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // DF0 Offset3552                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E00 Offset3568                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E10 Offset3584                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E20 Offset3600                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E30 Offset3616                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E40 Offset3632                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E50 Offset3648                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E60 Offset3664                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E70 Offset3680                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E80 Offset3696                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // E90 Offset3712                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // EA0 Offset3728                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // EB0 Offset3744                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // EC0 Offset3760                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // ED0 Offset3776                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // EE0 Offset3792                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // EF0 Offset3808                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F00 Offset3824                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F10 Offset3840                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F20 Offset3856                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F30 Offset3872                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F40 Offset3888                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F50 Offset3904                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F60 Offset3920                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F70 Offset3936                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F80 Offset3952                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // F90 Offset3968                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FA0 Offset3984                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FB0 Offset4000                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FC0 Offset4016                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FD0 Offset4032                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FE0 Offset4048                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // FF0 Offset4064                               00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32
    // 1000 Byte4080                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1001 Byte4081                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1002 Byte4082                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1003 Byte4083                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1004 Byte4084                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1005 Byte4085                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1006 Byte4086                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1007 Byte4087                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1008 Byte4088                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 1009 Byte4089                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 100A Byte4090                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 100B Byte4091                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 100C Byte4092                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 100D Byte4093                                 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class FixedBytes4094
    {
        public FixedBytes16                             Offset0000                              { get; set; }
        public FixedBytes16                             Offset0016                              { get; set; }
        public FixedBytes16                             Offset0032                              { get; set; }
        public FixedBytes16                             Offset0048                              { get; set; }
        public FixedBytes16                             Offset0064                              { get; set; }
        public FixedBytes16                             Offset0080                              { get; set; }
        public FixedBytes16                             Offset0096                              { get; set; }
        public FixedBytes16                             Offset0112                              { get; set; }
        public FixedBytes16                             Offset0128                              { get; set; }
        public FixedBytes16                             Offset0144                              { get; set; }
        public FixedBytes16                             Offset0160                              { get; set; }
        public FixedBytes16                             Offset0176                              { get; set; }
        public FixedBytes16                             Offset0192                              { get; set; }
        public FixedBytes16                             Offset0208                              { get; set; }
        public FixedBytes16                             Offset0224                              { get; set; }
        public FixedBytes16                             Offset0240                              { get; set; }
        public FixedBytes16                             Offset0256                              { get; set; }
        public FixedBytes16                             Offset0272                              { get; set; }
        public FixedBytes16                             Offset0288                              { get; set; }
        public FixedBytes16                             Offset0304                              { get; set; }
        public FixedBytes16                             Offset0320                              { get; set; }
        public FixedBytes16                             Offset0336                              { get; set; }
        public FixedBytes16                             Offset0352                              { get; set; }
        public FixedBytes16                             Offset0368                              { get; set; }
        public FixedBytes16                             Offset0384                              { get; set; }
        public FixedBytes16                             Offset0400                              { get; set; }
        public FixedBytes16                             Offset0416                              { get; set; }
        public FixedBytes16                             Offset0432                              { get; set; }
        public FixedBytes16                             Offset0448                              { get; set; }
        public FixedBytes16                             Offset0464                              { get; set; }
        public FixedBytes16                             Offset0480                              { get; set; }
        public FixedBytes16                             Offset0496                              { get; set; }
        public FixedBytes16                             Offset0512                              { get; set; }
        public FixedBytes16                             Offset0528                              { get; set; }
        public FixedBytes16                             Offset0544                              { get; set; }
        public FixedBytes16                             Offset0560                              { get; set; }
        public FixedBytes16                             Offset0576                              { get; set; }
        public FixedBytes16                             Offset0592                              { get; set; }
        public FixedBytes16                             Offset0608                              { get; set; }
        public FixedBytes16                             Offset0624                              { get; set; }
        public FixedBytes16                             Offset0640                              { get; set; }
        public FixedBytes16                             Offset0656                              { get; set; }
        public FixedBytes16                             Offset0672                              { get; set; }
        public FixedBytes16                             Offset0688                              { get; set; }
        public FixedBytes16                             Offset0704                              { get; set; }
        public FixedBytes16                             Offset0720                              { get; set; }
        public FixedBytes16                             Offset0736                              { get; set; }
        public FixedBytes16                             Offset0752                              { get; set; }
        public FixedBytes16                             Offset0768                              { get; set; }
        public FixedBytes16                             Offset0784                              { get; set; }
        public FixedBytes16                             Offset0800                              { get; set; }
        public FixedBytes16                             Offset0816                              { get; set; }
        public FixedBytes16                             Offset0832                              { get; set; }
        public FixedBytes16                             Offset0848                              { get; set; }
        public FixedBytes16                             Offset0864                              { get; set; }
        public FixedBytes16                             Offset0880                              { get; set; }
        public FixedBytes16                             Offset0896                              { get; set; }
        public FixedBytes16                             Offset0912                              { get; set; }
        public FixedBytes16                             Offset0928                              { get; set; }
        public FixedBytes16                             Offset0944                              { get; set; }
        public FixedBytes16                             Offset0960                              { get; set; }
        public FixedBytes16                             Offset0976                              { get; set; }
        public FixedBytes16                             Offset0992                              { get; set; }
        public FixedBytes16                             Offset1008                              { get; set; }
        public FixedBytes16                             Offset1024                              { get; set; }
        public FixedBytes16                             Offset1040                              { get; set; }
        public FixedBytes16                             Offset1056                              { get; set; }
        public FixedBytes16                             Offset1072                              { get; set; }
        public FixedBytes16                             Offset1088                              { get; set; }
        public FixedBytes16                             Offset1104                              { get; set; }
        public FixedBytes16                             Offset1120                              { get; set; }
        public FixedBytes16                             Offset1136                              { get; set; }
        public FixedBytes16                             Offset1152                              { get; set; }
        public FixedBytes16                             Offset1168                              { get; set; }
        public FixedBytes16                             Offset1184                              { get; set; }
        public FixedBytes16                             Offset1200                              { get; set; }
        public FixedBytes16                             Offset1216                              { get; set; }
        public FixedBytes16                             Offset1232                              { get; set; }
        public FixedBytes16                             Offset1248                              { get; set; }
        public FixedBytes16                             Offset1264                              { get; set; }
        public FixedBytes16                             Offset1280                              { get; set; }
        public FixedBytes16                             Offset1296                              { get; set; }
        public FixedBytes16                             Offset1312                              { get; set; }
        public FixedBytes16                             Offset1328                              { get; set; }
        public FixedBytes16                             Offset1344                              { get; set; }
        public FixedBytes16                             Offset1360                              { get; set; }
        public FixedBytes16                             Offset1376                              { get; set; }
        public FixedBytes16                             Offset1392                              { get; set; }
        public FixedBytes16                             Offset1408                              { get; set; }
        public FixedBytes16                             Offset1424                              { get; set; }
        public FixedBytes16                             Offset1440                              { get; set; }
        public FixedBytes16                             Offset1456                              { get; set; }
        public FixedBytes16                             Offset1472                              { get; set; }
        public FixedBytes16                             Offset1488                              { get; set; }
        public FixedBytes16                             Offset1504                              { get; set; }
        public FixedBytes16                             Offset1520                              { get; set; }
        public FixedBytes16                             Offset1536                              { get; set; }
        public FixedBytes16                             Offset1552                              { get; set; }
        public FixedBytes16                             Offset1568                              { get; set; }
        public FixedBytes16                             Offset1584                              { get; set; }
        public FixedBytes16                             Offset1600                              { get; set; }
        public FixedBytes16                             Offset1616                              { get; set; }
        public FixedBytes16                             Offset1632                              { get; set; }
        public FixedBytes16                             Offset1648                              { get; set; }
        public FixedBytes16                             Offset1664                              { get; set; }
        public FixedBytes16                             Offset1680                              { get; set; }
        public FixedBytes16                             Offset1696                              { get; set; }
        public FixedBytes16                             Offset1712                              { get; set; }
        public FixedBytes16                             Offset1728                              { get; set; }
        public FixedBytes16                             Offset1744                              { get; set; }
        public FixedBytes16                             Offset1760                              { get; set; }
        public FixedBytes16                             Offset1776                              { get; set; }
        public FixedBytes16                             Offset1792                              { get; set; }
        public FixedBytes16                             Offset1808                              { get; set; }
        public FixedBytes16                             Offset1824                              { get; set; }
        public FixedBytes16                             Offset1840                              { get; set; }
        public FixedBytes16                             Offset1856                              { get; set; }
        public FixedBytes16                             Offset1872                              { get; set; }
        public FixedBytes16                             Offset1888                              { get; set; }
        public FixedBytes16                             Offset1904                              { get; set; }
        public FixedBytes16                             Offset1920                              { get; set; }
        public FixedBytes16                             Offset1936                              { get; set; }
        public FixedBytes16                             Offset1952                              { get; set; }
        public FixedBytes16                             Offset1968                              { get; set; }
        public FixedBytes16                             Offset1984                              { get; set; }
        public FixedBytes16                             Offset2000                              { get; set; }
        public FixedBytes16                             Offset2016                              { get; set; }
        public FixedBytes16                             Offset2032                              { get; set; }
        public FixedBytes16                             Offset2048                              { get; set; }
        public FixedBytes16                             Offset2064                              { get; set; }
        public FixedBytes16                             Offset2080                              { get; set; }
        public FixedBytes16                             Offset2096                              { get; set; }
        public FixedBytes16                             Offset2112                              { get; set; }
        public FixedBytes16                             Offset2128                              { get; set; }
        public FixedBytes16                             Offset2144                              { get; set; }
        public FixedBytes16                             Offset2160                              { get; set; }
        public FixedBytes16                             Offset2176                              { get; set; }
        public FixedBytes16                             Offset2192                              { get; set; }
        public FixedBytes16                             Offset2208                              { get; set; }
        public FixedBytes16                             Offset2224                              { get; set; }
        public FixedBytes16                             Offset2240                              { get; set; }
        public FixedBytes16                             Offset2256                              { get; set; }
        public FixedBytes16                             Offset2272                              { get; set; }
        public FixedBytes16                             Offset2288                              { get; set; }
        public FixedBytes16                             Offset2304                              { get; set; }
        public FixedBytes16                             Offset2320                              { get; set; }
        public FixedBytes16                             Offset2336                              { get; set; }
        public FixedBytes16                             Offset2352                              { get; set; }
        public FixedBytes16                             Offset2368                              { get; set; }
        public FixedBytes16                             Offset2384                              { get; set; }
        public FixedBytes16                             Offset2400                              { get; set; }
        public FixedBytes16                             Offset2416                              { get; set; }
        public FixedBytes16                             Offset2432                              { get; set; }
        public FixedBytes16                             Offset2448                              { get; set; }
        public FixedBytes16                             Offset2464                              { get; set; }
        public FixedBytes16                             Offset2480                              { get; set; }
        public FixedBytes16                             Offset2496                              { get; set; }
        public FixedBytes16                             Offset2512                              { get; set; }
        public FixedBytes16                             Offset2528                              { get; set; }
        public FixedBytes16                             Offset2544                              { get; set; }
        public FixedBytes16                             Offset2560                              { get; set; }
        public FixedBytes16                             Offset2576                              { get; set; }
        public FixedBytes16                             Offset2592                              { get; set; }
        public FixedBytes16                             Offset2608                              { get; set; }
        public FixedBytes16                             Offset2624                              { get; set; }
        public FixedBytes16                             Offset2640                              { get; set; }
        public FixedBytes16                             Offset2656                              { get; set; }
        public FixedBytes16                             Offset2672                              { get; set; }
        public FixedBytes16                             Offset2688                              { get; set; }
        public FixedBytes16                             Offset2704                              { get; set; }
        public FixedBytes16                             Offset2720                              { get; set; }
        public FixedBytes16                             Offset2736                              { get; set; }
        public FixedBytes16                             Offset2752                              { get; set; }
        public FixedBytes16                             Offset2768                              { get; set; }
        public FixedBytes16                             Offset2784                              { get; set; }
        public FixedBytes16                             Offset2800                              { get; set; }
        public FixedBytes16                             Offset2816                              { get; set; }
        public FixedBytes16                             Offset2832                              { get; set; }
        public FixedBytes16                             Offset2848                              { get; set; }
        public FixedBytes16                             Offset2864                              { get; set; }
        public FixedBytes16                             Offset2880                              { get; set; }
        public FixedBytes16                             Offset2896                              { get; set; }
        public FixedBytes16                             Offset2912                              { get; set; }
        public FixedBytes16                             Offset2928                              { get; set; }
        public FixedBytes16                             Offset2944                              { get; set; }
        public FixedBytes16                             Offset2960                              { get; set; }
        public FixedBytes16                             Offset2976                              { get; set; }
        public FixedBytes16                             Offset2992                              { get; set; }
        public FixedBytes16                             Offset3008                              { get; set; }
        public FixedBytes16                             Offset3024                              { get; set; }
        public FixedBytes16                             Offset3040                              { get; set; }
        public FixedBytes16                             Offset3056                              { get; set; }
        public FixedBytes16                             Offset3072                              { get; set; }
        public FixedBytes16                             Offset3088                              { get; set; }
        public FixedBytes16                             Offset3104                              { get; set; }
        public FixedBytes16                             Offset3120                              { get; set; }
        public FixedBytes16                             Offset3136                              { get; set; }
        public FixedBytes16                             Offset3152                              { get; set; }
        public FixedBytes16                             Offset3168                              { get; set; }
        public FixedBytes16                             Offset3184                              { get; set; }
        public FixedBytes16                             Offset3200                              { get; set; }
        public FixedBytes16                             Offset3216                              { get; set; }
        public FixedBytes16                             Offset3232                              { get; set; }
        public FixedBytes16                             Offset3248                              { get; set; }
        public FixedBytes16                             Offset3264                              { get; set; }
        public FixedBytes16                             Offset3280                              { get; set; }
        public FixedBytes16                             Offset3296                              { get; set; }
        public FixedBytes16                             Offset3312                              { get; set; }
        public FixedBytes16                             Offset3328                              { get; set; }
        public FixedBytes16                             Offset3344                              { get; set; }
        public FixedBytes16                             Offset3360                              { get; set; }
        public FixedBytes16                             Offset3376                              { get; set; }
        public FixedBytes16                             Offset3392                              { get; set; }
        public FixedBytes16                             Offset3408                              { get; set; }
        public FixedBytes16                             Offset3424                              { get; set; }
        public FixedBytes16                             Offset3440                              { get; set; }
        public FixedBytes16                             Offset3456                              { get; set; }
        public FixedBytes16                             Offset3472                              { get; set; }
        public FixedBytes16                             Offset3488                              { get; set; }
        public FixedBytes16                             Offset3504                              { get; set; }
        public FixedBytes16                             Offset3520                              { get; set; }
        public FixedBytes16                             Offset3536                              { get; set; }
        public FixedBytes16                             Offset3552                              { get; set; }
        public FixedBytes16                             Offset3568                              { get; set; }
        public FixedBytes16                             Offset3584                              { get; set; }
        public FixedBytes16                             Offset3600                              { get; set; }
        public FixedBytes16                             Offset3616                              { get; set; }
        public FixedBytes16                             Offset3632                              { get; set; }
        public FixedBytes16                             Offset3648                              { get; set; }
        public FixedBytes16                             Offset3664                              { get; set; }
        public FixedBytes16                             Offset3680                              { get; set; }
        public FixedBytes16                             Offset3696                              { get; set; }
        public FixedBytes16                             Offset3712                              { get; set; }
        public FixedBytes16                             Offset3728                              { get; set; }
        public FixedBytes16                             Offset3744                              { get; set; }
        public FixedBytes16                             Offset3760                              { get; set; }
        public FixedBytes16                             Offset3776                              { get; set; }
        public FixedBytes16                             Offset3792                              { get; set; }
        public FixedBytes16                             Offset3808                              { get; set; }
        public FixedBytes16                             Offset3824                              { get; set; }
        public FixedBytes16                             Offset3840                              { get; set; }
        public FixedBytes16                             Offset3856                              { get; set; }
        public FixedBytes16                             Offset3872                              { get; set; }
        public FixedBytes16                             Offset3888                              { get; set; }
        public FixedBytes16                             Offset3904                              { get; set; }
        public FixedBytes16                             Offset3920                              { get; set; }
        public FixedBytes16                             Offset3936                              { get; set; }
        public FixedBytes16                             Offset3952                              { get; set; }
        public FixedBytes16                             Offset3968                              { get; set; }
        public FixedBytes16                             Offset3984                              { get; set; }
        public FixedBytes16                             Offset4000                              { get; set; }
        public FixedBytes16                             Offset4016                              { get; set; }
        public FixedBytes16                             Offset4032                              { get; set; }
        public FixedBytes16                             Offset4048                              { get; set; }
        public FixedBytes16                             Offset4064                              { get; set; }
        public sbyte                                    Byte4080                                { get; set; }
        public sbyte                                    Byte4081                                { get; set; }
        public sbyte                                    Byte4082                                { get; set; }
        public sbyte                                    Byte4083                                { get; set; }
        public sbyte                                    Byte4084                                { get; set; }
        public sbyte                                    Byte4085                                { get; set; }
        public sbyte                                    Byte4086                                { get; set; }
        public sbyte                                    Byte4087                                { get; set; }
        public sbyte                                    Byte4088                                { get; set; }
        public sbyte                                    Byte4089                                { get; set; }
        public sbyte                                    Byte4090                                { get; set; }
        public sbyte                                    Byte4091                                { get; set; }
        public sbyte                                    Byte4092                                { get; set; }
        public sbyte                                    Byte4093                                { get; set; }

        public static FixedBytes4094? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes4094();

            value.Offset0000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x010)); // 0270D9898870 0x10 Offset0000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x020)); // 0270D9898890 0x20 Offset0016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x030)); // 0270D98988B0 0x30 Offset0032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x040)); // 0270D98988D0 0x40 Offset0048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x050)); // 0270D98988F0 0x50 Offset0064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x060)); // 0270D9898910 0x60 Offset0080                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x070)); // 0270D9898930 0x70 Offset0096                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0112                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x080)); // 0270D9898950 0x80 Offset0112                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0128                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x090)); // 0270D9898970 0x90 Offset0128                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0144                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0A0)); // 0270D9898990 0xA0 Offset0144                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0160                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0B0)); // 0270D98989B0 0xB0 Offset0160                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0176                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0C0)); // 0270D98989D0 0xC0 Offset0176                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0192                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0D0)); // 0270D98989F0 0xD0 Offset0192                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0208                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0E0)); // 0270D9898A10 0xE0 Offset0208                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0224                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x0F0)); // 0270D9898A30 0xF0 Offset0224                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0240                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x100)); // 0270D9898A50 0x100 Offset0240                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0256                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x110)); // 0270D9898A70 0x110 Offset0256                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0272                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x120)); // 0270D9898A90 0x120 Offset0272                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0288                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x130)); // 0270D9898AB0 0x130 Offset0288                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0304                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x140)); // 0270D9898AD0 0x140 Offset0304                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0320                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x150)); // 0270D9898AF0 0x150 Offset0320                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0336                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x160)); // 0270D9898B10 0x160 Offset0336                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0352                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x170)); // 0270D9898B30 0x170 Offset0352                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0368                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x180)); // 0270D9898B50 0x180 Offset0368                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0384                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x190)); // 0270D9898B70 0x190 Offset0384                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0400                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1A0)); // 0270D9898B90 0x1A0 Offset0400                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0416                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1B0)); // 0270D9898BB0 0x1B0 Offset0416                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0432                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1C0)); // 0270D9898BD0 0x1C0 Offset0432                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0448                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1D0)); // 0270D9898BF0 0x1D0 Offset0448                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0464                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1E0)); // 0270D9898C10 0x1E0 Offset0464                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0480                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x1F0)); // 0270D9898C30 0x1F0 Offset0480                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0496                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x200)); // 0270D9898C50 0x200 Offset0496                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0512                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x210)); // 0270D9898C70 0x210 Offset0512                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0528                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x220)); // 0270D9898C90 0x220 Offset0528                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0544                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x230)); // 0270D9898CB0 0x230 Offset0544                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0560                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x240)); // 0270D9898CD0 0x240 Offset0560                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0576                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x250)); // 0270D9898CF0 0x250 Offset0576                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0592                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x260)); // 0270D9898D10 0x260 Offset0592                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0608                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x270)); // 0270D9898D30 0x270 Offset0608                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0624                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x280)); // 0270D9898D50 0x280 Offset0624                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0640                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x290)); // 0270D9898D70 0x290 Offset0640                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0656                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2A0)); // 0270D9898D90 0x2A0 Offset0656                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0672                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2B0)); // 0270D9898DB0 0x2B0 Offset0672                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0688                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2C0)); // 0270D9898DD0 0x2C0 Offset0688                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0704                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2D0)); // 0270D9898DF0 0x2D0 Offset0704                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0720                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2E0)); // 0270D9898E10 0x2E0 Offset0720                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0736                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x2F0)); // 0270D9898E30 0x2F0 Offset0736                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0752                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x300)); // 0270D9898E50 0x300 Offset0752                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0768                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x310)); // 0270D9898E70 0x310 Offset0768                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0784                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x320)); // 0270D9898E90 0x320 Offset0784                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0800                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x330)); // 0270D9898EB0 0x330 Offset0800                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0816                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x340)); // 0270D9898ED0 0x340 Offset0816                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0832                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x350)); // 0270D9898EF0 0x350 Offset0832                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0848                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x360)); // 0270D9898F10 0x360 Offset0848                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0864                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x370)); // 0270D9898F30 0x370 Offset0864                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0880                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x380)); // 0270D9898F50 0x380 Offset0880                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0896                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x390)); // 0270D9898F70 0x390 Offset0896                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0912                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3A0)); // 0270D9898F90 0x3A0 Offset0912                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0928                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3B0)); // 0270D9898FB0 0x3B0 Offset0928                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0944                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3C0)); // 0270D9898FD0 0x3C0 Offset0944                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0960                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3D0)); // 0270D9898FF0 0x3D0 Offset0960                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0976                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3E0)); // 0270D9899010 0x3E0 Offset0976                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset0992                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x3F0)); // 0270D9899030 0x3F0 Offset0992                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1008                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x400)); // 0270D9899050 0x400 Offset1008                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1024                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x410)); // 0270D9899070 0x410 Offset1024                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1040                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x420)); // 0270D9899090 0x420 Offset1040                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1056                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x430)); // 0270D98990B0 0x430 Offset1056                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1072                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x440)); // 0270D98990D0 0x440 Offset1072                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1088                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x450)); // 0270D98990F0 0x450 Offset1088                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1104                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x460)); // 0270D9899110 0x460 Offset1104                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1120                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x470)); // 0270D9899130 0x470 Offset1120                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1136                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x480)); // 0270D9899150 0x480 Offset1136                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1152                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x490)); // 0270D9899170 0x490 Offset1152                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1168                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4A0)); // 0270D9899190 0x4A0 Offset1168                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1184                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4B0)); // 0270D98991B0 0x4B0 Offset1184                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1200                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4C0)); // 0270D98991D0 0x4C0 Offset1200                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1216                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4D0)); // 0270D98991F0 0x4D0 Offset1216                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1232                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4E0)); // 0270D9899210 0x4E0 Offset1232                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1248                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x4F0)); // 0270D9899230 0x4F0 Offset1248                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1264                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x500)); // 0270D9899250 0x500 Offset1264                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1280                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x510)); // 0270D9899270 0x510 Offset1280                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1296                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x520)); // 0270D9899290 0x520 Offset1296                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1312                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x530)); // 0270D98992B0 0x530 Offset1312                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1328                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x540)); // 0270D98992D0 0x540 Offset1328                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1344                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x550)); // 0270D98992F0 0x550 Offset1344                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1360                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x560)); // 0270D9899310 0x560 Offset1360                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1376                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x570)); // 0270D9899330 0x570 Offset1376                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1392                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x580)); // 0270D9899350 0x580 Offset1392                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1408                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x590)); // 0270D9899370 0x590 Offset1408                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1424                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5A0)); // 0270D9899390 0x5A0 Offset1424                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1440                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5B0)); // 0270D98993B0 0x5B0 Offset1440                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1456                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5C0)); // 0270D98993D0 0x5C0 Offset1456                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1472                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5D0)); // 0270D98993F0 0x5D0 Offset1472                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1488                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5E0)); // 0270D9899410 0x5E0 Offset1488                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1504                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x5F0)); // 0270D9899430 0x5F0 Offset1504                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1520                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x600)); // 0270D9899450 0x600 Offset1520                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1536                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x610)); // 0270D9899470 0x610 Offset1536                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1552                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x620)); // 0270D9899490 0x620 Offset1552                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1568                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x630)); // 0270D98994B0 0x630 Offset1568                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1584                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x640)); // 0270D98994D0 0x640 Offset1584                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1600                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x650)); // 0270D98994F0 0x650 Offset1600                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1616                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x660)); // 0270D9899510 0x660 Offset1616                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1632                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x670)); // 0270D9899530 0x670 Offset1632                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1648                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x680)); // 0270D9899550 0x680 Offset1648                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1664                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x690)); // 0270D9899570 0x690 Offset1664                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1680                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6A0)); // 0270D9899590 0x6A0 Offset1680                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1696                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6B0)); // 0270D98995B0 0x6B0 Offset1696                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1712                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6C0)); // 0270D98995D0 0x6C0 Offset1712                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1728                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6D0)); // 0270D98995F0 0x6D0 Offset1728                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1744                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6E0)); // 0270D9899610 0x6E0 Offset1744                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1760                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x6F0)); // 0270D9899630 0x6F0 Offset1760                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1776                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x700)); // 0270D9899650 0x700 Offset1776                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1792                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x710)); // 0270D9899670 0x710 Offset1792                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1808                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x720)); // 0270D9899690 0x720 Offset1808                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1824                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x730)); // 0270D98996B0 0x730 Offset1824                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1840                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x740)); // 0270D98996D0 0x740 Offset1840                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1856                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x750)); // 0270D98996F0 0x750 Offset1856                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1872                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x760)); // 0270D9899710 0x760 Offset1872                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1888                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x770)); // 0270D9899730 0x770 Offset1888                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1904                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x780)); // 0270D9899750 0x780 Offset1904                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1920                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x790)); // 0270D9899770 0x790 Offset1920                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1936                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7A0)); // 0270D9899790 0x7A0 Offset1936                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1952                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7B0)); // 0270D98997B0 0x7B0 Offset1952                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1968                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7C0)); // 0270D98997D0 0x7C0 Offset1968                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset1984                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7D0)); // 0270D98997F0 0x7D0 Offset1984                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7E0)); // 0270D9899810 0x7E0 Offset2000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x7F0)); // 0270D9899830 0x7F0 Offset2016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x800)); // 0270D9899850 0x800 Offset2032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x810)); // 0270D9899870 0x810 Offset2048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x820)); // 0270D9899890 0x820 Offset2064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2080                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x830)); // 0270D98998B0 0x830 Offset2080                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2096                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x840)); // 0270D98998D0 0x840 Offset2096                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2112                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x850)); // 0270D98998F0 0x850 Offset2112                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2128                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x860)); // 0270D9899910 0x860 Offset2128                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2144                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x870)); // 0270D9899930 0x870 Offset2144                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2160                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x880)); // 0270D9899950 0x880 Offset2160                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2176                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x890)); // 0270D9899970 0x890 Offset2176                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2192                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8A0)); // 0270D9899990 0x8A0 Offset2192                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2208                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8B0)); // 0270D98999B0 0x8B0 Offset2208                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2224                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8C0)); // 0270D98999D0 0x8C0 Offset2224                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2240                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8D0)); // 0270D98999F0 0x8D0 Offset2240                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2256                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8E0)); // 0270D9899A10 0x8E0 Offset2256                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2272                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x8F0)); // 0270D9899A30 0x8F0 Offset2272                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2288                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x900)); // 0270D9899A50 0x900 Offset2288                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2304                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x910)); // 0270D9899A70 0x910 Offset2304                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2320                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x920)); // 0270D9899A90 0x920 Offset2320                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2336                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x930)); // 0270D9899AB0 0x930 Offset2336                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2352                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x940)); // 0270D9899AD0 0x940 Offset2352                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2368                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x950)); // 0270D9899AF0 0x950 Offset2368                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2384                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x960)); // 0270D9899B10 0x960 Offset2384                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2400                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x970)); // 0270D9899B30 0x970 Offset2400                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2416                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x980)); // 0270D9899B50 0x980 Offset2416                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2432                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x990)); // 0270D9899B70 0x990 Offset2432                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2448                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9A0)); // 0270D9899B90 0x9A0 Offset2448                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2464                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9B0)); // 0270D9899BB0 0x9B0 Offset2464                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2480                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9C0)); // 0270D9899BD0 0x9C0 Offset2480                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2496                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9D0)); // 0270D9899BF0 0x9D0 Offset2496                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2512                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9E0)); // 0270D9899C10 0x9E0 Offset2512                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2528                                = (FixedBytes16)GetInt32(new IntPtr(p + 0x9F0)); // 0270D9899C30 0x9F0 Offset2528                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2544                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA00)); // 0270D9899C50 0xA00 Offset2544                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2560                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA10)); // 0270D9899C70 0xA10 Offset2560                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2576                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA20)); // 0270D9899C90 0xA20 Offset2576                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2592                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA30)); // 0270D9899CB0 0xA30 Offset2592                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2608                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA40)); // 0270D9899CD0 0xA40 Offset2608                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2624                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA50)); // 0270D9899CF0 0xA50 Offset2624                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2640                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA60)); // 0270D9899D10 0xA60 Offset2640                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2656                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA70)); // 0270D9899D30 0xA70 Offset2656                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2672                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA80)); // 0270D9899D50 0xA80 Offset2672                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2688                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xA90)); // 0270D9899D70 0xA90 Offset2688                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2704                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAA0)); // 0270D9899D90 0xAA0 Offset2704                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2720                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAB0)); // 0270D9899DB0 0xAB0 Offset2720                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2736                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAC0)); // 0270D9899DD0 0xAC0 Offset2736                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2752                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAD0)); // 0270D9899DF0 0xAD0 Offset2752                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2768                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAE0)); // 0270D9899E10 0xAE0 Offset2768                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2784                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xAF0)); // 0270D9899E30 0xAF0 Offset2784                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2800                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB00)); // 0270D9899E50 0xB00 Offset2800                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2816                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB10)); // 0270D9899E70 0xB10 Offset2816                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2832                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB20)); // 0270D9899E90 0xB20 Offset2832                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2848                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB30)); // 0270D9899EB0 0xB30 Offset2848                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2864                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB40)); // 0270D9899ED0 0xB40 Offset2864                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2880                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB50)); // 0270D9899EF0 0xB50 Offset2880                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2896                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB60)); // 0270D9899F10 0xB60 Offset2896                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2912                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB70)); // 0270D9899F30 0xB70 Offset2912                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2928                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB80)); // 0270D9899F50 0xB80 Offset2928                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2944                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xB90)); // 0270D9899F70 0xB90 Offset2944                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2960                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBA0)); // 0270D9899F90 0xBA0 Offset2960                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2976                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBB0)); // 0270D9899FB0 0xBB0 Offset2976                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset2992                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBC0)); // 0270D9899FD0 0xBC0 Offset2992                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3008                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBD0)); // 0270D9899FF0 0xBD0 Offset3008                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3024                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBE0)); // 0270D989A010 0xBE0 Offset3024                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3040                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xBF0)); // 0270D989A030 0xBF0 Offset3040                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3056                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC00)); // 0270D989A050 0xC00 Offset3056                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3072                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC10)); // 0270D989A070 0xC10 Offset3072                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3088                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC20)); // 0270D989A090 0xC20 Offset3088                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3104                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC30)); // 0270D989A0B0 0xC30 Offset3104                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3120                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC40)); // 0270D989A0D0 0xC40 Offset3120                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3136                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC50)); // 0270D989A0F0 0xC50 Offset3136                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3152                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC60)); // 0270D989A110 0xC60 Offset3152                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3168                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC70)); // 0270D989A130 0xC70 Offset3168                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3184                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC80)); // 0270D989A150 0xC80 Offset3184                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3200                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xC90)); // 0270D989A170 0xC90 Offset3200                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3216                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCA0)); // 0270D989A190 0xCA0 Offset3216                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3232                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCB0)); // 0270D989A1B0 0xCB0 Offset3232                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3248                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCC0)); // 0270D989A1D0 0xCC0 Offset3248                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3264                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCD0)); // 0270D989A1F0 0xCD0 Offset3264                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3280                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCE0)); // 0270D989A210 0xCE0 Offset3280                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3296                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xCF0)); // 0270D989A230 0xCF0 Offset3296                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3312                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD00)); // 0270D989A250 0xD00 Offset3312                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3328                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD10)); // 0270D989A270 0xD10 Offset3328                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3344                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD20)); // 0270D989A290 0xD20 Offset3344                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3360                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD30)); // 0270D989A2B0 0xD30 Offset3360                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3376                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD40)); // 0270D989A2D0 0xD40 Offset3376                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3392                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD50)); // 0270D989A2F0 0xD50 Offset3392                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3408                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD60)); // 0270D989A310 0xD60 Offset3408                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3424                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD70)); // 0270D989A330 0xD70 Offset3424                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3440                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD80)); // 0270D989A350 0xD80 Offset3440                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3456                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xD90)); // 0270D989A370 0xD90 Offset3456                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3472                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDA0)); // 0270D989A390 0xDA0 Offset3472                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3488                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDB0)); // 0270D989A3B0 0xDB0 Offset3488                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3504                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDC0)); // 0270D989A3D0 0xDC0 Offset3504                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3520                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDD0)); // 0270D989A3F0 0xDD0 Offset3520                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3536                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDE0)); // 0270D989A410 0xDE0 Offset3536                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3552                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xDF0)); // 0270D989A430 0xDF0 Offset3552                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3568                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE00)); // 0270D989A450 0xE00 Offset3568                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3584                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE10)); // 0270D989A470 0xE10 Offset3584                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3600                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE20)); // 0270D989A490 0xE20 Offset3600                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3616                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE30)); // 0270D989A4B0 0xE30 Offset3616                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3632                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE40)); // 0270D989A4D0 0xE40 Offset3632                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3648                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE50)); // 0270D989A4F0 0xE50 Offset3648                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3664                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE60)); // 0270D989A510 0xE60 Offset3664                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3680                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE70)); // 0270D989A530 0xE70 Offset3680                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3696                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE80)); // 0270D989A550 0xE80 Offset3696                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3712                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xE90)); // 0270D989A570 0xE90 Offset3712                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3728                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xEA0)); // 0270D989A590 0xEA0 Offset3728                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3744                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xEB0)); // 0270D989A5B0 0xEB0 Offset3744                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3760                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xEC0)); // 0270D989A5D0 0xEC0 Offset3760                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3776                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xED0)); // 0270D989A5F0 0xED0 Offset3776                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3792                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xEE0)); // 0270D989A610 0xEE0 Offset3792                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3808                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xEF0)); // 0270D989A630 0xEF0 Offset3808                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3824                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF00)); // 0270D989A650 0xF00 Offset3824                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3840                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF10)); // 0270D989A670 0xF10 Offset3840                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3856                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF20)); // 0270D989A690 0xF20 Offset3856                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3872                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF30)); // 0270D989A6B0 0xF30 Offset3872                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3888                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF40)); // 0270D989A6D0 0xF40 Offset3888                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3904                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF50)); // 0270D989A6F0 0xF50 Offset3904                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3920                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF60)); // 0270D989A710 0xF60 Offset3920                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3936                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF70)); // 0270D989A730 0xF70 Offset3936                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3952                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF80)); // 0270D989A750 0xF80 Offset3952                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3968                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xF90)); // 0270D989A770 0xF90 Offset3968                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset3984                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFA0)); // 0270D989A790 0xFA0 Offset3984                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset4000                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFB0)); // 0270D989A7B0 0xFB0 Offset4000                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset4016                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFC0)); // 0270D989A7D0 0xFC0 Offset4016                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset4032                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFD0)); // 0270D989A7F0 0xFD0 Offset4032                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset4048                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFE0)); // 0270D989A810 0xFE0 Offset4048                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Offset4064                                = (FixedBytes16)GetInt32(new IntPtr(p + 0xFF0)); // 0270D989A830 0xFF0 Offset4064                  ( 00018659BD00 ModelEnumType FixedBytes16 FixedBytes16 FixedBytes16 Int32 )
            value.Byte4080                                  = GetSByte(new IntPtr(p + 0x1000)); // 0270D989A850 0x1000 Byte4080                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4081                                  = GetSByte(new IntPtr(p + 0x1001)); // 0270D989A870 0x1001 Byte4081                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4082                                  = GetSByte(new IntPtr(p + 0x1002)); // 0270D989A890 0x1002 Byte4082                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4083                                  = GetSByte(new IntPtr(p + 0x1003)); // 0270D989A8B0 0x1003 Byte4083                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4084                                  = GetSByte(new IntPtr(p + 0x1004)); // 0270D989A8D0 0x1004 Byte4084                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4085                                  = GetSByte(new IntPtr(p + 0x1005)); // 0270D989A8F0 0x1005 Byte4085                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4086                                  = GetSByte(new IntPtr(p + 0x1006)); // 0270D989A910 0x1006 Byte4086                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4087                                  = GetSByte(new IntPtr(p + 0x1007)); // 0270D989A930 0x1007 Byte4087                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4088                                  = GetSByte(new IntPtr(p + 0x1008)); // 0270D989A950 0x1008 Byte4088                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4089                                  = GetSByte(new IntPtr(p + 0x1009)); // 0270D989A970 0x1009 Byte4089                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4090                                  = GetSByte(new IntPtr(p + 0x100A)); // 0270D989A990 0x100A Byte4090                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4091                                  = GetSByte(new IntPtr(p + 0x100B)); // 0270D989A9B0 0x100B Byte4091                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4092                                  = GetSByte(new IntPtr(p + 0x100C)); // 0270D989A9D0 0x100C Byte4092                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Byte4093                                  = GetSByte(new IntPtr(p + 0x100D)); // 0270D989A9F0 0x100D Byte4093                    ( 00018659CEE0 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
