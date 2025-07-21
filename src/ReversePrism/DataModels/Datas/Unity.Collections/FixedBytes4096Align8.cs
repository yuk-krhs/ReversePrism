using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset0000                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 020 Offset0016                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 030 Offset0032                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 040 Offset0048                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 050 Offset0064                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 060 Offset0080                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 070 Offset0096                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 080 Offset0112                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 090 Offset0128                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0A0 Offset0144                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0B0 Offset0160                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0C0 Offset0176                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0D0 Offset0192                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0E0 Offset0208                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 0F0 Offset0224                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 100 Offset0240                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 110 Offset0256                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 120 Offset0272                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 130 Offset0288                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 140 Offset0304                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 150 Offset0320                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 160 Offset0336                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 170 Offset0352                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 180 Offset0368                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 190 Offset0384                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1A0 Offset0400                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1B0 Offset0416                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1C0 Offset0432                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1D0 Offset0448                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1E0 Offset0464                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1F0 Offset0480                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 200 Offset0496                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 210 Offset0512                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 220 Offset0528                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 230 Offset0544                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 240 Offset0560                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 250 Offset0576                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 260 Offset0592                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 270 Offset0608                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 280 Offset0624                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 290 Offset0640                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2A0 Offset0656                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2B0 Offset0672                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2C0 Offset0688                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2D0 Offset0704                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2E0 Offset0720                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 2F0 Offset0736                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 300 Offset0752                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 310 Offset0768                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 320 Offset0784                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 330 Offset0800                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 340 Offset0816                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 350 Offset0832                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 360 Offset0848                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 370 Offset0864                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 380 Offset0880                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 390 Offset0896                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3A0 Offset0912                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3B0 Offset0928                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3C0 Offset0944                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3D0 Offset0960                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3E0 Offset0976                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 3F0 Offset0992                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 400 Offset1008                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 410 Offset1024                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 420 Offset1040                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 430 Offset1056                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 440 Offset1072                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 450 Offset1088                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 460 Offset1104                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 470 Offset1120                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 480 Offset1136                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 490 Offset1152                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4A0 Offset1168                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4B0 Offset1184                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4C0 Offset1200                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4D0 Offset1216                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4E0 Offset1232                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 4F0 Offset1248                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 500 Offset1264                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 510 Offset1280                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 520 Offset1296                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 530 Offset1312                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 540 Offset1328                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 550 Offset1344                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 560 Offset1360                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 570 Offset1376                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 580 Offset1392                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 590 Offset1408                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5A0 Offset1424                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5B0 Offset1440                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5C0 Offset1456                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5D0 Offset1472                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5E0 Offset1488                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 5F0 Offset1504                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 600 Offset1520                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 610 Offset1536                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 620 Offset1552                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 630 Offset1568                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 640 Offset1584                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 650 Offset1600                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 660 Offset1616                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 670 Offset1632                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 680 Offset1648                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 690 Offset1664                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6A0 Offset1680                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6B0 Offset1696                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6C0 Offset1712                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6D0 Offset1728                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6E0 Offset1744                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 6F0 Offset1760                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 700 Offset1776                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 710 Offset1792                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 720 Offset1808                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 730 Offset1824                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 740 Offset1840                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 750 Offset1856                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 760 Offset1872                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 770 Offset1888                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 780 Offset1904                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 790 Offset1920                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7A0 Offset1936                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7B0 Offset1952                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7C0 Offset1968                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7D0 Offset1984                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7E0 Offset2000                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 7F0 Offset2016                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 800 Offset2032                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 810 Offset2048                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 820 Offset2064                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 830 Offset2080                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 840 Offset2096                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 850 Offset2112                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 860 Offset2128                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 870 Offset2144                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 880 Offset2160                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 890 Offset2176                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8A0 Offset2192                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8B0 Offset2208                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8C0 Offset2224                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8D0 Offset2240                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8E0 Offset2256                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 8F0 Offset2272                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 900 Offset2288                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 910 Offset2304                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 920 Offset2320                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 930 Offset2336                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 940 Offset2352                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 950 Offset2368                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 960 Offset2384                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 970 Offset2400                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 980 Offset2416                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 990 Offset2432                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9A0 Offset2448                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9B0 Offset2464                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9C0 Offset2480                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9D0 Offset2496                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9E0 Offset2512                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 9F0 Offset2528                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A00 Offset2544                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A10 Offset2560                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A20 Offset2576                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A30 Offset2592                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A40 Offset2608                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A50 Offset2624                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A60 Offset2640                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A70 Offset2656                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A80 Offset2672                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // A90 Offset2688                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AA0 Offset2704                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AB0 Offset2720                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AC0 Offset2736                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AD0 Offset2752                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AE0 Offset2768                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // AF0 Offset2784                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B00 Offset2800                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B10 Offset2816                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B20 Offset2832                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B30 Offset2848                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B40 Offset2864                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B50 Offset2880                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B60 Offset2896                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B70 Offset2912                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B80 Offset2928                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // B90 Offset2944                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BA0 Offset2960                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BB0 Offset2976                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BC0 Offset2992                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BD0 Offset3008                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BE0 Offset3024                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // BF0 Offset3040                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C00 Offset3056                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C10 Offset3072                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C20 Offset3088                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C30 Offset3104                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C40 Offset3120                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C50 Offset3136                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C60 Offset3152                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C70 Offset3168                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C80 Offset3184                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // C90 Offset3200                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CA0 Offset3216                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CB0 Offset3232                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CC0 Offset3248                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CD0 Offset3264                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CE0 Offset3280                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // CF0 Offset3296                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D00 Offset3312                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D10 Offset3328                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D20 Offset3344                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D30 Offset3360                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D40 Offset3376                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D50 Offset3392                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D60 Offset3408                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D70 Offset3424                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D80 Offset3440                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // D90 Offset3456                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DA0 Offset3472                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DB0 Offset3488                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DC0 Offset3504                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DD0 Offset3520                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DE0 Offset3536                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // DF0 Offset3552                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E00 Offset3568                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E10 Offset3584                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E20 Offset3600                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E30 Offset3616                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E40 Offset3632                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E50 Offset3648                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E60 Offset3664                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E70 Offset3680                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E80 Offset3696                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // E90 Offset3712                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // EA0 Offset3728                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // EB0 Offset3744                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // EC0 Offset3760                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // ED0 Offset3776                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // EE0 Offset3792                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // EF0 Offset3808                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F00 Offset3824                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F10 Offset3840                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F20 Offset3856                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F30 Offset3872                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F40 Offset3888                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F50 Offset3904                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F60 Offset3920                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F70 Offset3936                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F80 Offset3952                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // F90 Offset3968                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FA0 Offset3984                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FB0 Offset4000                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FC0 Offset4016                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FD0 Offset4032                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FE0 Offset4048                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // FF0 Offset4064                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    // 1000 Offset4080                               ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32
    public partial class FixedBytes4096Align8 : DataModel
    {
        public FixedBytes16Align8                       Offset0000                              { get; set; }
        public FixedBytes16Align8                       Offset0016                              { get; set; }
        public FixedBytes16Align8                       Offset0032                              { get; set; }
        public FixedBytes16Align8                       Offset0048                              { get; set; }
        public FixedBytes16Align8                       Offset0064                              { get; set; }
        public FixedBytes16Align8                       Offset0080                              { get; set; }
        public FixedBytes16Align8                       Offset0096                              { get; set; }
        public FixedBytes16Align8                       Offset0112                              { get; set; }
        public FixedBytes16Align8                       Offset0128                              { get; set; }
        public FixedBytes16Align8                       Offset0144                              { get; set; }
        public FixedBytes16Align8                       Offset0160                              { get; set; }
        public FixedBytes16Align8                       Offset0176                              { get; set; }
        public FixedBytes16Align8                       Offset0192                              { get; set; }
        public FixedBytes16Align8                       Offset0208                              { get; set; }
        public FixedBytes16Align8                       Offset0224                              { get; set; }
        public FixedBytes16Align8                       Offset0240                              { get; set; }
        public FixedBytes16Align8                       Offset0256                              { get; set; }
        public FixedBytes16Align8                       Offset0272                              { get; set; }
        public FixedBytes16Align8                       Offset0288                              { get; set; }
        public FixedBytes16Align8                       Offset0304                              { get; set; }
        public FixedBytes16Align8                       Offset0320                              { get; set; }
        public FixedBytes16Align8                       Offset0336                              { get; set; }
        public FixedBytes16Align8                       Offset0352                              { get; set; }
        public FixedBytes16Align8                       Offset0368                              { get; set; }
        public FixedBytes16Align8                       Offset0384                              { get; set; }
        public FixedBytes16Align8                       Offset0400                              { get; set; }
        public FixedBytes16Align8                       Offset0416                              { get; set; }
        public FixedBytes16Align8                       Offset0432                              { get; set; }
        public FixedBytes16Align8                       Offset0448                              { get; set; }
        public FixedBytes16Align8                       Offset0464                              { get; set; }
        public FixedBytes16Align8                       Offset0480                              { get; set; }
        public FixedBytes16Align8                       Offset0496                              { get; set; }
        public FixedBytes16Align8                       Offset0512                              { get; set; }
        public FixedBytes16Align8                       Offset0528                              { get; set; }
        public FixedBytes16Align8                       Offset0544                              { get; set; }
        public FixedBytes16Align8                       Offset0560                              { get; set; }
        public FixedBytes16Align8                       Offset0576                              { get; set; }
        public FixedBytes16Align8                       Offset0592                              { get; set; }
        public FixedBytes16Align8                       Offset0608                              { get; set; }
        public FixedBytes16Align8                       Offset0624                              { get; set; }
        public FixedBytes16Align8                       Offset0640                              { get; set; }
        public FixedBytes16Align8                       Offset0656                              { get; set; }
        public FixedBytes16Align8                       Offset0672                              { get; set; }
        public FixedBytes16Align8                       Offset0688                              { get; set; }
        public FixedBytes16Align8                       Offset0704                              { get; set; }
        public FixedBytes16Align8                       Offset0720                              { get; set; }
        public FixedBytes16Align8                       Offset0736                              { get; set; }
        public FixedBytes16Align8                       Offset0752                              { get; set; }
        public FixedBytes16Align8                       Offset0768                              { get; set; }
        public FixedBytes16Align8                       Offset0784                              { get; set; }
        public FixedBytes16Align8                       Offset0800                              { get; set; }
        public FixedBytes16Align8                       Offset0816                              { get; set; }
        public FixedBytes16Align8                       Offset0832                              { get; set; }
        public FixedBytes16Align8                       Offset0848                              { get; set; }
        public FixedBytes16Align8                       Offset0864                              { get; set; }
        public FixedBytes16Align8                       Offset0880                              { get; set; }
        public FixedBytes16Align8                       Offset0896                              { get; set; }
        public FixedBytes16Align8                       Offset0912                              { get; set; }
        public FixedBytes16Align8                       Offset0928                              { get; set; }
        public FixedBytes16Align8                       Offset0944                              { get; set; }
        public FixedBytes16Align8                       Offset0960                              { get; set; }
        public FixedBytes16Align8                       Offset0976                              { get; set; }
        public FixedBytes16Align8                       Offset0992                              { get; set; }
        public FixedBytes16Align8                       Offset1008                              { get; set; }
        public FixedBytes16Align8                       Offset1024                              { get; set; }
        public FixedBytes16Align8                       Offset1040                              { get; set; }
        public FixedBytes16Align8                       Offset1056                              { get; set; }
        public FixedBytes16Align8                       Offset1072                              { get; set; }
        public FixedBytes16Align8                       Offset1088                              { get; set; }
        public FixedBytes16Align8                       Offset1104                              { get; set; }
        public FixedBytes16Align8                       Offset1120                              { get; set; }
        public FixedBytes16Align8                       Offset1136                              { get; set; }
        public FixedBytes16Align8                       Offset1152                              { get; set; }
        public FixedBytes16Align8                       Offset1168                              { get; set; }
        public FixedBytes16Align8                       Offset1184                              { get; set; }
        public FixedBytes16Align8                       Offset1200                              { get; set; }
        public FixedBytes16Align8                       Offset1216                              { get; set; }
        public FixedBytes16Align8                       Offset1232                              { get; set; }
        public FixedBytes16Align8                       Offset1248                              { get; set; }
        public FixedBytes16Align8                       Offset1264                              { get; set; }
        public FixedBytes16Align8                       Offset1280                              { get; set; }
        public FixedBytes16Align8                       Offset1296                              { get; set; }
        public FixedBytes16Align8                       Offset1312                              { get; set; }
        public FixedBytes16Align8                       Offset1328                              { get; set; }
        public FixedBytes16Align8                       Offset1344                              { get; set; }
        public FixedBytes16Align8                       Offset1360                              { get; set; }
        public FixedBytes16Align8                       Offset1376                              { get; set; }
        public FixedBytes16Align8                       Offset1392                              { get; set; }
        public FixedBytes16Align8                       Offset1408                              { get; set; }
        public FixedBytes16Align8                       Offset1424                              { get; set; }
        public FixedBytes16Align8                       Offset1440                              { get; set; }
        public FixedBytes16Align8                       Offset1456                              { get; set; }
        public FixedBytes16Align8                       Offset1472                              { get; set; }
        public FixedBytes16Align8                       Offset1488                              { get; set; }
        public FixedBytes16Align8                       Offset1504                              { get; set; }
        public FixedBytes16Align8                       Offset1520                              { get; set; }
        public FixedBytes16Align8                       Offset1536                              { get; set; }
        public FixedBytes16Align8                       Offset1552                              { get; set; }
        public FixedBytes16Align8                       Offset1568                              { get; set; }
        public FixedBytes16Align8                       Offset1584                              { get; set; }
        public FixedBytes16Align8                       Offset1600                              { get; set; }
        public FixedBytes16Align8                       Offset1616                              { get; set; }
        public FixedBytes16Align8                       Offset1632                              { get; set; }
        public FixedBytes16Align8                       Offset1648                              { get; set; }
        public FixedBytes16Align8                       Offset1664                              { get; set; }
        public FixedBytes16Align8                       Offset1680                              { get; set; }
        public FixedBytes16Align8                       Offset1696                              { get; set; }
        public FixedBytes16Align8                       Offset1712                              { get; set; }
        public FixedBytes16Align8                       Offset1728                              { get; set; }
        public FixedBytes16Align8                       Offset1744                              { get; set; }
        public FixedBytes16Align8                       Offset1760                              { get; set; }
        public FixedBytes16Align8                       Offset1776                              { get; set; }
        public FixedBytes16Align8                       Offset1792                              { get; set; }
        public FixedBytes16Align8                       Offset1808                              { get; set; }
        public FixedBytes16Align8                       Offset1824                              { get; set; }
        public FixedBytes16Align8                       Offset1840                              { get; set; }
        public FixedBytes16Align8                       Offset1856                              { get; set; }
        public FixedBytes16Align8                       Offset1872                              { get; set; }
        public FixedBytes16Align8                       Offset1888                              { get; set; }
        public FixedBytes16Align8                       Offset1904                              { get; set; }
        public FixedBytes16Align8                       Offset1920                              { get; set; }
        public FixedBytes16Align8                       Offset1936                              { get; set; }
        public FixedBytes16Align8                       Offset1952                              { get; set; }
        public FixedBytes16Align8                       Offset1968                              { get; set; }
        public FixedBytes16Align8                       Offset1984                              { get; set; }
        public FixedBytes16Align8                       Offset2000                              { get; set; }
        public FixedBytes16Align8                       Offset2016                              { get; set; }
        public FixedBytes16Align8                       Offset2032                              { get; set; }
        public FixedBytes16Align8                       Offset2048                              { get; set; }
        public FixedBytes16Align8                       Offset2064                              { get; set; }
        public FixedBytes16Align8                       Offset2080                              { get; set; }
        public FixedBytes16Align8                       Offset2096                              { get; set; }
        public FixedBytes16Align8                       Offset2112                              { get; set; }
        public FixedBytes16Align8                       Offset2128                              { get; set; }
        public FixedBytes16Align8                       Offset2144                              { get; set; }
        public FixedBytes16Align8                       Offset2160                              { get; set; }
        public FixedBytes16Align8                       Offset2176                              { get; set; }
        public FixedBytes16Align8                       Offset2192                              { get; set; }
        public FixedBytes16Align8                       Offset2208                              { get; set; }
        public FixedBytes16Align8                       Offset2224                              { get; set; }
        public FixedBytes16Align8                       Offset2240                              { get; set; }
        public FixedBytes16Align8                       Offset2256                              { get; set; }
        public FixedBytes16Align8                       Offset2272                              { get; set; }
        public FixedBytes16Align8                       Offset2288                              { get; set; }
        public FixedBytes16Align8                       Offset2304                              { get; set; }
        public FixedBytes16Align8                       Offset2320                              { get; set; }
        public FixedBytes16Align8                       Offset2336                              { get; set; }
        public FixedBytes16Align8                       Offset2352                              { get; set; }
        public FixedBytes16Align8                       Offset2368                              { get; set; }
        public FixedBytes16Align8                       Offset2384                              { get; set; }
        public FixedBytes16Align8                       Offset2400                              { get; set; }
        public FixedBytes16Align8                       Offset2416                              { get; set; }
        public FixedBytes16Align8                       Offset2432                              { get; set; }
        public FixedBytes16Align8                       Offset2448                              { get; set; }
        public FixedBytes16Align8                       Offset2464                              { get; set; }
        public FixedBytes16Align8                       Offset2480                              { get; set; }
        public FixedBytes16Align8                       Offset2496                              { get; set; }
        public FixedBytes16Align8                       Offset2512                              { get; set; }
        public FixedBytes16Align8                       Offset2528                              { get; set; }
        public FixedBytes16Align8                       Offset2544                              { get; set; }
        public FixedBytes16Align8                       Offset2560                              { get; set; }
        public FixedBytes16Align8                       Offset2576                              { get; set; }
        public FixedBytes16Align8                       Offset2592                              { get; set; }
        public FixedBytes16Align8                       Offset2608                              { get; set; }
        public FixedBytes16Align8                       Offset2624                              { get; set; }
        public FixedBytes16Align8                       Offset2640                              { get; set; }
        public FixedBytes16Align8                       Offset2656                              { get; set; }
        public FixedBytes16Align8                       Offset2672                              { get; set; }
        public FixedBytes16Align8                       Offset2688                              { get; set; }
        public FixedBytes16Align8                       Offset2704                              { get; set; }
        public FixedBytes16Align8                       Offset2720                              { get; set; }
        public FixedBytes16Align8                       Offset2736                              { get; set; }
        public FixedBytes16Align8                       Offset2752                              { get; set; }
        public FixedBytes16Align8                       Offset2768                              { get; set; }
        public FixedBytes16Align8                       Offset2784                              { get; set; }
        public FixedBytes16Align8                       Offset2800                              { get; set; }
        public FixedBytes16Align8                       Offset2816                              { get; set; }
        public FixedBytes16Align8                       Offset2832                              { get; set; }
        public FixedBytes16Align8                       Offset2848                              { get; set; }
        public FixedBytes16Align8                       Offset2864                              { get; set; }
        public FixedBytes16Align8                       Offset2880                              { get; set; }
        public FixedBytes16Align8                       Offset2896                              { get; set; }
        public FixedBytes16Align8                       Offset2912                              { get; set; }
        public FixedBytes16Align8                       Offset2928                              { get; set; }
        public FixedBytes16Align8                       Offset2944                              { get; set; }
        public FixedBytes16Align8                       Offset2960                              { get; set; }
        public FixedBytes16Align8                       Offset2976                              { get; set; }
        public FixedBytes16Align8                       Offset2992                              { get; set; }
        public FixedBytes16Align8                       Offset3008                              { get; set; }
        public FixedBytes16Align8                       Offset3024                              { get; set; }
        public FixedBytes16Align8                       Offset3040                              { get; set; }
        public FixedBytes16Align8                       Offset3056                              { get; set; }
        public FixedBytes16Align8                       Offset3072                              { get; set; }
        public FixedBytes16Align8                       Offset3088                              { get; set; }
        public FixedBytes16Align8                       Offset3104                              { get; set; }
        public FixedBytes16Align8                       Offset3120                              { get; set; }
        public FixedBytes16Align8                       Offset3136                              { get; set; }
        public FixedBytes16Align8                       Offset3152                              { get; set; }
        public FixedBytes16Align8                       Offset3168                              { get; set; }
        public FixedBytes16Align8                       Offset3184                              { get; set; }
        public FixedBytes16Align8                       Offset3200                              { get; set; }
        public FixedBytes16Align8                       Offset3216                              { get; set; }
        public FixedBytes16Align8                       Offset3232                              { get; set; }
        public FixedBytes16Align8                       Offset3248                              { get; set; }
        public FixedBytes16Align8                       Offset3264                              { get; set; }
        public FixedBytes16Align8                       Offset3280                              { get; set; }
        public FixedBytes16Align8                       Offset3296                              { get; set; }
        public FixedBytes16Align8                       Offset3312                              { get; set; }
        public FixedBytes16Align8                       Offset3328                              { get; set; }
        public FixedBytes16Align8                       Offset3344                              { get; set; }
        public FixedBytes16Align8                       Offset3360                              { get; set; }
        public FixedBytes16Align8                       Offset3376                              { get; set; }
        public FixedBytes16Align8                       Offset3392                              { get; set; }
        public FixedBytes16Align8                       Offset3408                              { get; set; }
        public FixedBytes16Align8                       Offset3424                              { get; set; }
        public FixedBytes16Align8                       Offset3440                              { get; set; }
        public FixedBytes16Align8                       Offset3456                              { get; set; }
        public FixedBytes16Align8                       Offset3472                              { get; set; }
        public FixedBytes16Align8                       Offset3488                              { get; set; }
        public FixedBytes16Align8                       Offset3504                              { get; set; }
        public FixedBytes16Align8                       Offset3520                              { get; set; }
        public FixedBytes16Align8                       Offset3536                              { get; set; }
        public FixedBytes16Align8                       Offset3552                              { get; set; }
        public FixedBytes16Align8                       Offset3568                              { get; set; }
        public FixedBytes16Align8                       Offset3584                              { get; set; }
        public FixedBytes16Align8                       Offset3600                              { get; set; }
        public FixedBytes16Align8                       Offset3616                              { get; set; }
        public FixedBytes16Align8                       Offset3632                              { get; set; }
        public FixedBytes16Align8                       Offset3648                              { get; set; }
        public FixedBytes16Align8                       Offset3664                              { get; set; }
        public FixedBytes16Align8                       Offset3680                              { get; set; }
        public FixedBytes16Align8                       Offset3696                              { get; set; }
        public FixedBytes16Align8                       Offset3712                              { get; set; }
        public FixedBytes16Align8                       Offset3728                              { get; set; }
        public FixedBytes16Align8                       Offset3744                              { get; set; }
        public FixedBytes16Align8                       Offset3760                              { get; set; }
        public FixedBytes16Align8                       Offset3776                              { get; set; }
        public FixedBytes16Align8                       Offset3792                              { get; set; }
        public FixedBytes16Align8                       Offset3808                              { get; set; }
        public FixedBytes16Align8                       Offset3824                              { get; set; }
        public FixedBytes16Align8                       Offset3840                              { get; set; }
        public FixedBytes16Align8                       Offset3856                              { get; set; }
        public FixedBytes16Align8                       Offset3872                              { get; set; }
        public FixedBytes16Align8                       Offset3888                              { get; set; }
        public FixedBytes16Align8                       Offset3904                              { get; set; }
        public FixedBytes16Align8                       Offset3920                              { get; set; }
        public FixedBytes16Align8                       Offset3936                              { get; set; }
        public FixedBytes16Align8                       Offset3952                              { get; set; }
        public FixedBytes16Align8                       Offset3968                              { get; set; }
        public FixedBytes16Align8                       Offset3984                              { get; set; }
        public FixedBytes16Align8                       Offset4000                              { get; set; }
        public FixedBytes16Align8                       Offset4016                              { get; set; }
        public FixedBytes16Align8                       Offset4032                              { get; set; }
        public FixedBytes16Align8                       Offset4048                              { get; set; }
        public FixedBytes16Align8                       Offset4064                              { get; set; }
        public FixedBytes16Align8                       Offset4080                              { get; set; }

        public static FixedBytes4096Align8? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FixedBytes4096Align8() { Pointer= p0 };

            value.Offset0000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset0000                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x020)); // 0x20 Offset0016                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0032                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x030)); // 0x30 Offset0032                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0048                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x040)); // 0x40 Offset0048                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0064                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x050)); // 0x50 Offset0064                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0080                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x060)); // 0x60 Offset0080                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0096                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x070)); // 0x70 Offset0096                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0112                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x080)); // 0x80 Offset0112                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0128                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x090)); // 0x90 Offset0128                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0144                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 Offset0144                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0160                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 Offset0160                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0176                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Offset0176                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0192                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 Offset0192                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0208                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 Offset0208                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0224                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 Offset0224                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0240                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x100)); // 0x100 Offset0240                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0256                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x110)); // 0x110 Offset0256                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0272                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x120)); // 0x120 Offset0272                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0288                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x130)); // 0x130 Offset0288                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0304                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x140)); // 0x140 Offset0304                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0320                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x150)); // 0x150 Offset0320                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0336                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x160)); // 0x160 Offset0336                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0352                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x170)); // 0x170 Offset0352                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0368                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x180)); // 0x180 Offset0368                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0384                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x190)); // 0x190 Offset0384                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0400                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1A0)); // 0x1A0 Offset0400                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0416                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1B0)); // 0x1B0 Offset0416                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0432                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 Offset0432                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0448                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1D0)); // 0x1D0 Offset0448                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0464                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1E0)); // 0x1E0 Offset0464                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0480                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1F0)); // 0x1F0 Offset0480                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0496                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x200)); // 0x200 Offset0496                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0512                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x210)); // 0x210 Offset0512                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0528                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x220)); // 0x220 Offset0528                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0544                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x230)); // 0x230 Offset0544                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0560                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x240)); // 0x240 Offset0560                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0576                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x250)); // 0x250 Offset0576                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0592                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x260)); // 0x260 Offset0592                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0608                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x270)); // 0x270 Offset0608                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0624                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x280)); // 0x280 Offset0624                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0640                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x290)); // 0x290 Offset0640                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0656                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2A0)); // 0x2A0 Offset0656                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0672                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2B0)); // 0x2B0 Offset0672                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0688                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2C0)); // 0x2C0 Offset0688                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0704                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2D0)); // 0x2D0 Offset0704                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0720                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2E0)); // 0x2E0 Offset0720                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0736                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x2F0)); // 0x2F0 Offset0736                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0752                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x300)); // 0x300 Offset0752                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0768                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x310)); // 0x310 Offset0768                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0784                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x320)); // 0x320 Offset0784                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0800                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x330)); // 0x330 Offset0800                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0816                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x340)); // 0x340 Offset0816                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0832                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x350)); // 0x350 Offset0832                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0848                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x360)); // 0x360 Offset0848                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0864                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x370)); // 0x370 Offset0864                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0880                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x380)); // 0x380 Offset0880                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0896                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x390)); // 0x390 Offset0896                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0912                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3A0)); // 0x3A0 Offset0912                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0928                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3B0)); // 0x3B0 Offset0928                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0944                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3C0)); // 0x3C0 Offset0944                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0960                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3D0)); // 0x3D0 Offset0960                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0976                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3E0)); // 0x3E0 Offset0976                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset0992                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x3F0)); // 0x3F0 Offset0992                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1008                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x400)); // 0x400 Offset1008                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1024                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x410)); // 0x410 Offset1024                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1040                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x420)); // 0x420 Offset1040                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1056                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x430)); // 0x430 Offset1056                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1072                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x440)); // 0x440 Offset1072                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1088                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x450)); // 0x450 Offset1088                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1104                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x460)); // 0x460 Offset1104                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1120                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x470)); // 0x470 Offset1120                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1136                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x480)); // 0x480 Offset1136                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1152                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x490)); // 0x490 Offset1152                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1168                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4A0)); // 0x4A0 Offset1168                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1184                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4B0)); // 0x4B0 Offset1184                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1200                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4C0)); // 0x4C0 Offset1200                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1216                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4D0)); // 0x4D0 Offset1216                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1232                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4E0)); // 0x4E0 Offset1232                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1248                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x4F0)); // 0x4F0 Offset1248                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1264                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x500)); // 0x500 Offset1264                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1280                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x510)); // 0x510 Offset1280                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1296                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x520)); // 0x520 Offset1296                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1312                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x530)); // 0x530 Offset1312                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1328                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x540)); // 0x540 Offset1328                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1344                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x550)); // 0x550 Offset1344                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1360                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x560)); // 0x560 Offset1360                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1376                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x570)); // 0x570 Offset1376                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1392                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x580)); // 0x580 Offset1392                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1408                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x590)); // 0x590 Offset1408                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1424                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5A0)); // 0x5A0 Offset1424                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1440                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5B0)); // 0x5B0 Offset1440                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1456                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5C0)); // 0x5C0 Offset1456                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1472                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5D0)); // 0x5D0 Offset1472                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1488                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5E0)); // 0x5E0 Offset1488                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1504                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x5F0)); // 0x5F0 Offset1504                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1520                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x600)); // 0x600 Offset1520                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1536                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x610)); // 0x610 Offset1536                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1552                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x620)); // 0x620 Offset1552                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1568                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x630)); // 0x630 Offset1568                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1584                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x640)); // 0x640 Offset1584                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1600                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x650)); // 0x650 Offset1600                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1616                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x660)); // 0x660 Offset1616                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1632                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x670)); // 0x670 Offset1632                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1648                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x680)); // 0x680 Offset1648                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1664                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x690)); // 0x690 Offset1664                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1680                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6A0)); // 0x6A0 Offset1680                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1696                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6B0)); // 0x6B0 Offset1696                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1712                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6C0)); // 0x6C0 Offset1712                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1728                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6D0)); // 0x6D0 Offset1728                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1744                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6E0)); // 0x6E0 Offset1744                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1760                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x6F0)); // 0x6F0 Offset1760                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1776                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x700)); // 0x700 Offset1776                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1792                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x710)); // 0x710 Offset1792                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1808                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x720)); // 0x720 Offset1808                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1824                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x730)); // 0x730 Offset1824                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1840                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x740)); // 0x740 Offset1840                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1856                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x750)); // 0x750 Offset1856                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1872                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x760)); // 0x760 Offset1872                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1888                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x770)); // 0x770 Offset1888                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1904                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x780)); // 0x780 Offset1904                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1920                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x790)); // 0x790 Offset1920                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1936                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7A0)); // 0x7A0 Offset1936                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1952                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7B0)); // 0x7B0 Offset1952                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1968                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7C0)); // 0x7C0 Offset1968                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset1984                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7D0)); // 0x7D0 Offset1984                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7E0)); // 0x7E0 Offset2000                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x7F0)); // 0x7F0 Offset2016                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2032                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x800)); // 0x800 Offset2032                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2048                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x810)); // 0x810 Offset2048                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2064                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x820)); // 0x820 Offset2064                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2080                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x830)); // 0x830 Offset2080                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2096                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x840)); // 0x840 Offset2096                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2112                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x850)); // 0x850 Offset2112                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2128                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x860)); // 0x860 Offset2128                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2144                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x870)); // 0x870 Offset2144                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2160                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x880)); // 0x880 Offset2160                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2176                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x890)); // 0x890 Offset2176                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2192                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8A0)); // 0x8A0 Offset2192                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2208                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8B0)); // 0x8B0 Offset2208                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2224                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8C0)); // 0x8C0 Offset2224                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2240                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8D0)); // 0x8D0 Offset2240                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2256                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8E0)); // 0x8E0 Offset2256                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2272                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x8F0)); // 0x8F0 Offset2272                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2288                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x900)); // 0x900 Offset2288                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2304                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x910)); // 0x910 Offset2304                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2320                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x920)); // 0x920 Offset2320                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2336                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x930)); // 0x930 Offset2336                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2352                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x940)); // 0x940 Offset2352                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2368                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x950)); // 0x950 Offset2368                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2384                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x960)); // 0x960 Offset2384                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2400                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x970)); // 0x970 Offset2400                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2416                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x980)); // 0x980 Offset2416                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2432                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x990)); // 0x990 Offset2432                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2448                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9A0)); // 0x9A0 Offset2448                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2464                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9B0)); // 0x9B0 Offset2464                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2480                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9C0)); // 0x9C0 Offset2480                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2496                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9D0)); // 0x9D0 Offset2496                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2512                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9E0)); // 0x9E0 Offset2512                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2528                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x9F0)); // 0x9F0 Offset2528                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2544                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA00)); // 0xA00 Offset2544                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2560                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA10)); // 0xA10 Offset2560                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2576                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA20)); // 0xA20 Offset2576                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2592                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA30)); // 0xA30 Offset2592                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2608                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA40)); // 0xA40 Offset2608                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2624                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA50)); // 0xA50 Offset2624                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2640                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA60)); // 0xA60 Offset2640                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2656                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA70)); // 0xA70 Offset2656                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2672                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA80)); // 0xA80 Offset2672                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2688                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xA90)); // 0xA90 Offset2688                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2704                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAA0)); // 0xAA0 Offset2704                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2720                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAB0)); // 0xAB0 Offset2720                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2736                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAC0)); // 0xAC0 Offset2736                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2752                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAD0)); // 0xAD0 Offset2752                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2768                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAE0)); // 0xAE0 Offset2768                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2784                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xAF0)); // 0xAF0 Offset2784                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2800                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB00)); // 0xB00 Offset2800                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2816                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB10)); // 0xB10 Offset2816                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2832                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB20)); // 0xB20 Offset2832                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2848                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB30)); // 0xB30 Offset2848                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2864                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB40)); // 0xB40 Offset2864                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2880                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB50)); // 0xB50 Offset2880                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2896                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB60)); // 0xB60 Offset2896                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2912                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB70)); // 0xB70 Offset2912                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2928                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB80)); // 0xB80 Offset2928                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2944                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xB90)); // 0xB90 Offset2944                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2960                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBA0)); // 0xBA0 Offset2960                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2976                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBB0)); // 0xBB0 Offset2976                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset2992                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBC0)); // 0xBC0 Offset2992                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3008                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBD0)); // 0xBD0 Offset3008                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3024                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBE0)); // 0xBE0 Offset3024                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3040                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xBF0)); // 0xBF0 Offset3040                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3056                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC00)); // 0xC00 Offset3056                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3072                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC10)); // 0xC10 Offset3072                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3088                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC20)); // 0xC20 Offset3088                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3104                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC30)); // 0xC30 Offset3104                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3120                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC40)); // 0xC40 Offset3120                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3136                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC50)); // 0xC50 Offset3136                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3152                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC60)); // 0xC60 Offset3152                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3168                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC70)); // 0xC70 Offset3168                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3184                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC80)); // 0xC80 Offset3184                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3200                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xC90)); // 0xC90 Offset3200                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3216                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCA0)); // 0xCA0 Offset3216                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3232                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCB0)); // 0xCB0 Offset3232                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3248                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCC0)); // 0xCC0 Offset3248                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3264                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCD0)); // 0xCD0 Offset3264                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3280                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCE0)); // 0xCE0 Offset3280                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3296                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xCF0)); // 0xCF0 Offset3296                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3312                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD00)); // 0xD00 Offset3312                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3328                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD10)); // 0xD10 Offset3328                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3344                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD20)); // 0xD20 Offset3344                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3360                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD30)); // 0xD30 Offset3360                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3376                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD40)); // 0xD40 Offset3376                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3392                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD50)); // 0xD50 Offset3392                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3408                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD60)); // 0xD60 Offset3408                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3424                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD70)); // 0xD70 Offset3424                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3440                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD80)); // 0xD80 Offset3440                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3456                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xD90)); // 0xD90 Offset3456                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3472                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDA0)); // 0xDA0 Offset3472                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3488                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDB0)); // 0xDB0 Offset3488                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3504                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDC0)); // 0xDC0 Offset3504                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3520                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDD0)); // 0xDD0 Offset3520                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3536                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDE0)); // 0xDE0 Offset3536                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3552                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xDF0)); // 0xDF0 Offset3552                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3568                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE00)); // 0xE00 Offset3568                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3584                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE10)); // 0xE10 Offset3584                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3600                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE20)); // 0xE20 Offset3600                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3616                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE30)); // 0xE30 Offset3616                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3632                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE40)); // 0xE40 Offset3632                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3648                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE50)); // 0xE50 Offset3648                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3664                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE60)); // 0xE60 Offset3664                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3680                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE70)); // 0xE70 Offset3680                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3696                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE80)); // 0xE80 Offset3696                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3712                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xE90)); // 0xE90 Offset3712                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3728                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xEA0)); // 0xEA0 Offset3728                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3744                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xEB0)); // 0xEB0 Offset3744                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3760                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xEC0)); // 0xEC0 Offset3760                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3776                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xED0)); // 0xED0 Offset3776                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3792                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xEE0)); // 0xEE0 Offset3792                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3808                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xEF0)); // 0xEF0 Offset3808                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3824                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF00)); // 0xF00 Offset3824                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3840                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF10)); // 0xF10 Offset3840                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3856                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF20)); // 0xF20 Offset3856                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3872                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF30)); // 0xF30 Offset3872                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3888                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF40)); // 0xF40 Offset3888                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3904                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF50)); // 0xF50 Offset3904                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3920                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF60)); // 0xF60 Offset3920                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3936                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF70)); // 0xF70 Offset3936                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3952                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF80)); // 0xF80 Offset3952                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3968                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xF90)); // 0xF90 Offset3968                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset3984                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFA0)); // 0xFA0 Offset3984                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4000                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFB0)); // 0xFB0 Offset4000                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4016                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFC0)); // 0xFC0 Offset4016                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4032                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFD0)); // 0xFD0 Offset4032                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4048                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFE0)); // 0xFE0 Offset4048                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4064                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0xFF0)); // 0xFF0 Offset4064                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )
            value.Offset4080                                = (FixedBytes16Align8)GetInt32(new IntPtr(p + 0x1000)); // 0x1000 Offset4080                  ( ModelEnumType FixedBytes16Align8 FixedBytes16Align8 FixedBytes16Align8 Int32 )

            return value;
        }
    }
}
