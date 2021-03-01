
Public Class Form1

    Public StockData(11, 48) As Double
    Public Stonks(11) As Stocks
    Public Time As Integer = 0
    Public Money As Double = 200
    Public GamePaused As Boolean = True
    Public GameTimeInSeconds As Integer = 0
    Public TimeIntervalInSeconds As Integer = 20
    Public TimeArray(48) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TimeArray(0) = "December 2004"
        TimeArray(1) = "April 2005"
        TimeArray(2) = "August 2005"
        TimeArray(3) = "December 2005"
        TimeArray(4) = "April 2006"
        TimeArray(5) = "August 2006"
        TimeArray(6) = "December 2006"
        TimeArray(7) = "April 2007"
        TimeArray(8) = "August 2007"
        TimeArray(9) = "December 2007"
        TimeArray(10) = "April 2008"
        TimeArray(11) = "August 2008"
        TimeArray(12) = "December 2008"
        TimeArray(13) = "April 2009"
        TimeArray(14) = "August 2009"
        TimeArray(15) = "December 2009"
        TimeArray(16) = "April 2010"
        TimeArray(17) = "August 2010"
        TimeArray(18) = "December 2010"
        TimeArray(19) = "April 2011"
        TimeArray(20) = "August 2011"
        TimeArray(21) = "December 2011"
        TimeArray(22) = "April 2012"
        TimeArray(23) = "August 2012"
        TimeArray(24) = "December 2012"
        TimeArray(25) = "April 2013"
        TimeArray(26) = "August 2013"
        TimeArray(27) = "December 2013"
        TimeArray(28) = "April 2014"
        TimeArray(29) = "August 2014"
        TimeArray(30) = "December 2014"
        TimeArray(31) = "April 2015"
        TimeArray(32) = "August 2015"
        TimeArray(33) = "December 2015"
        TimeArray(34) = "April 2016"
        TimeArray(35) = "August 2016"
        TimeArray(36) = "December 2016"
        TimeArray(37) = "April 2017"
        TimeArray(38) = "August 2017"
        TimeArray(39) = "December 2017"
        TimeArray(40) = "April 2018"
        TimeArray(41) = "August 2018"
        TimeArray(42) = "December 2018"
        TimeArray(43) = "April 2019"
        TimeArray(44) = "August 2019"
        TimeArray(45) = "December 2019"
        TimeArray(46) = "April 2020"
        TimeArray(47) = "August 2020"
        TimeArray(48) = "December 2020"

        StockData(0, 0) = 10
        StockData(0, 1) = 9.28
        StockData(0, 2) = 10.09
        StockData(0, 3) = 10.85
        StockData(0, 4) = 10.94
        StockData(0, 5) = 11.37
        StockData(0, 6) = 13.5
        StockData(0, 7) = 14.29
        StockData(0, 8) = 14.43
        StockData(0, 9) = 15.15
        StockData(0, 10) = 13.42
        StockData(0, 11) = 12.58
        StockData(0, 12) = 10.04
        StockData(0, 13) = 10.28
        StockData(0, 14) = 10.27
        StockData(0, 15) = 9.05
        StockData(0, 16) = 9.7
        StockData(0, 17) = 8.39
        StockData(0, 18) = 10.95
        StockData(0, 19) = 11.48
        StockData(0, 20) = 8.74
        StockData(0, 21) = 9.27
        StockData(0, 22) = 9.14
        StockData(0, 23) = 9.82
        StockData(0, 24) = 9.58
        StockData(0, 25) = 7.56
        StockData(0, 26) = 8.63
        StockData(0, 27) = 10.04
        StockData(0, 28) = 9.81
        StockData(0, 29) = 8.51
        StockData(0, 30) = 7.42
        StockData(0, 31) = 8.49
        StockData(0, 32) = 9.54
        StockData(0, 33) = 9.46
        StockData(0, 34) = 8.35
        StockData(0, 35) = 9.88
        StockData(0, 36) = 9.41
        StockData(0, 37) = 10.22
        StockData(0, 38) = 9.41
        StockData(0, 39) = 10.4
        StockData(0, 40) = 10.3
        StockData(0, 41) = 10.14
        StockData(0, 42) = 8.73
        StockData(0, 43) = 8.79
        StockData(0, 44) = 7.55
        StockData(0, 45) = 9.15
        StockData(0, 46) = 9.09
        StockData(0, 47) = 7.81
        StockData(0, 48) = 9.46
        StockData(1, 0) = 10
        StockData(1, 1) = 9.4
        StockData(1, 2) = 9.13
        StockData(1, 3) = 9.53
        StockData(1, 4) = 11.29
        StockData(1, 5) = 11.46
        StockData(1, 6) = 13.17
        StockData(1, 7) = 13.15
        StockData(1, 8) = 11.23
        StockData(1, 9) = 9.14
        StockData(1, 10) = 8.24
        StockData(1, 11) = 5.82
        StockData(1, 12) = 2.22
        StockData(1, 13) = 3.63
        StockData(1, 14) = 5.54
        StockData(1, 15) = 3.99
        StockData(1, 16) = 4.63
        StockData(1, 17) = 4.2
        StockData(1, 18) = 3.74
        StockData(1, 19) = 4.31
        StockData(1, 20) = 2.53
        StockData(1, 21) = 2.49
        StockData(1, 22) = 3.23
        StockData(1, 23) = 2.63
        StockData(1, 24) = 3.92
        StockData(1, 25) = 4.07
        StockData(1, 26) = 3.96
        StockData(1, 27) = 4.46
        StockData(1, 28) = 4.2
        StockData(1, 29) = 3.69
        StockData(1, 30) = 3.69
        StockData(1, 31) = 3.87
        StockData(1, 32) = 3.92
        StockData(1, 33) = 3.18
        StockData(1, 34) = 2.47
        StockData(1, 35) = 2.24
        StockData(1, 36) = 2.7
        StockData(1, 37) = 2.66
        StockData(1, 38) = 2.43
        StockData(1, 39) = 2.68
        StockData(1, 40) = 2.84
        StockData(1, 41) = 2.3
        StockData(1, 42) = 1.85
        StockData(1, 43) = 2.1
        StockData(1, 44) = 1.63
        StockData(1, 45) = 2.34
        StockData(1, 46) = 1.3
        StockData(1, 47) = 1.43
        StockData(1, 48) = 1.96
        StockData(2, 0) = 10
        StockData(2, 1) = 9.03
        StockData(2, 2) = 10.98
        StockData(2, 3) = 9.26
        StockData(2, 4) = 10.75
        StockData(2, 5) = 11.57
        StockData(2, 6) = 17.92
        StockData(2, 7) = 18.46
        StockData(2, 8) = 35.94
        StockData(2, 9) = 47.72
        StockData(2, 10) = 51.18
        StockData(2, 11) = 51.17
        StockData(2, 12) = 17.08
        StockData(2, 13) = 29.25
        StockData(2, 14) = 30.74
        StockData(2, 15) = 28.42
        StockData(2, 16) = 29.96
        StockData(2, 17) = 18.03
        StockData(2, 18) = 24.46
        StockData(2, 19) = 20.47
        StockData(2, 20) = 13.67
        StockData(2, 21) = 6.1
        StockData(2, 22) = 6.02
        StockData(2, 23) = 2.82
        StockData(2, 24) = 5
        StockData(2, 25) = 6.86
        StockData(2, 26) = 4.26
        StockData(2, 27) = 3.13
        StockData(2, 28) = 3.22
        StockData(2, 29) = 4.28
        StockData(2, 30) = 4.62
        StockData(2, 31) = 4.28
        StockData(2, 32) = 3.19
        StockData(2, 33) = 3.91
        StockData(2, 34) = 2.97
        StockData(2, 35) = 3.19
        StockData(2, 36) = 2.9
        StockData(2, 37) = 3.93
        StockData(2, 38) = 3.9
        StockData(2, 39) = 4.7
        StockData(2, 40) = 4.41
        StockData(2, 41) = 4.49
        StockData(2, 42) = 2.99
        StockData(2, 43) = 3.86
        StockData(2, 44) = 2.89
        StockData(2, 45) = 2.7
        StockData(2, 46) = 1.8
        StockData(2, 47) = 2.2
        StockData(2, 48) = 2.79
        StockData(3, 0) = 10
        StockData(3, 1) = 10.21
        StockData(3, 2) = 12.08
        StockData(3, 3) = 11.84
        StockData(3, 4) = 12.93
        StockData(3, 5) = 11.41
        StockData(3, 6) = 10.85
        StockData(3, 7) = 10.81
        StockData(3, 8) = 10.66
        StockData(3, 9) = 11.76
        StockData(3, 10) = 11.68
        StockData(3, 11) = 10.11
        StockData(3, 12) = 10.06
        StockData(3, 13) = 9.23
        StockData(3, 14) = 10.17
        StockData(3, 15) = 11.47
        StockData(3, 16) = 11
        StockData(3, 17) = 7.28
        StockData(3, 18) = 8.9
        StockData(3, 19) = 8.84
        StockData(3, 20) = 7.7
        StockData(3, 21) = 8.8
        StockData(3, 22) = 8.51
        StockData(3, 23) = 8.44
        StockData(3, 24) = 8.12
        StockData(3, 25) = 8.92
        StockData(3, 26) = 8.53
        StockData(3, 27) = 9.33
        StockData(3, 28) = 9.54
        StockData(3, 29) = 9.21
        StockData(3, 30) = 7.86
        StockData(3, 31) = 8.99
        StockData(3, 32) = 6.89
        StockData(3, 33) = 6.77
        StockData(3, 34) = 7.15
        StockData(3, 35) = 8.18
        StockData(3, 36) = 9.74
        StockData(3, 37) = 8.46
        StockData(3, 38) = 8.51
        StockData(3, 39) = 9.99
        StockData(3, 40) = 10.29
        StockData(3, 41) = 10.46
        StockData(3, 42) = 9.48
        StockData(3, 43) = 10.69
        StockData(3, 44) = 9.56
        StockData(3, 45) = 9.02
        StockData(3, 46) = 5.99
        StockData(3, 47) = 5.05
        StockData(3, 48) = 4.87
        StockData(4, 0) = 0
        StockData(4, 1) = 0
        StockData(4, 2) = 0
        StockData(4, 3) = 10
        StockData(4, 4) = 14.49
        StockData(4, 5) = 13.89
        StockData(4, 6) = 17.26
        StockData(4, 7) = 20.04
        StockData(4, 8) = 23.18
        StockData(4, 9) = 25.48
        StockData(4, 10) = 21.01
        StockData(4, 11) = 18.26
        StockData(4, 12) = 12.98
        StockData(4, 13) = 11.04
        StockData(4, 14) = 11.43
        StockData(4, 15) = 13
        StockData(4, 16) = 12.65
        StockData(4, 17) = 9.83
        StockData(4, 18) = 9.6
        StockData(4, 19) = 8.89
        StockData(4, 20) = 6.67
        StockData(4, 21) = 5.88
        StockData(4, 22) = 5
        StockData(4, 23) = 5.06
        StockData(4, 24) = 4.37
        StockData(4, 25) = 5.31
        StockData(4, 26) = 6.63
        StockData(4, 27) = 8.03
        StockData(4, 28) = 8.64
        StockData(4, 29) = 7.74
        StockData(4, 30) = 7.14
        StockData(4, 31) = 7.11
        StockData(4, 32) = 6.03
        StockData(4, 33) = 4.24
        StockData(4, 34) = 3.92
        StockData(4, 35) = 3.59
        StockData(4, 36) = 3.03
        StockData(4, 37) = 2.4
        StockData(4, 38) = 2.78
        StockData(4, 39) = 3.26
        StockData(4, 40) = 3.64
        StockData(4, 41) = 4.41
        StockData(4, 42) = 4.32
        StockData(4, 43) = 4.02
        StockData(4, 44) = 3.46
        StockData(4, 45) = 3.1
        StockData(4, 46) = 2.27
        StockData(4, 47) = 2.75
        StockData(4, 48) = 4.03
        StockData(5, 0) = 10
        StockData(5, 1) = 12.89
        StockData(5, 2) = 17.68
        StockData(5, 3) = 16.67
        StockData(5, 4) = 24.72
        StockData(5, 5) = 22.88
        StockData(5, 6) = 28.87
        StockData(5, 7) = 34.75
        StockData(5, 8) = 52.53
        StockData(5, 9) = 65.07
        StockData(5, 10) = 57.66
        StockData(5, 11) = 45.96
        StockData(5, 12) = 22.69
        StockData(5, 13) = 31.6
        StockData(5, 14) = 24.93
        StockData(5, 15) = 22.99
        StockData(5, 16) = 25.47
        StockData(5, 17) = 18.78
        StockData(5, 18) = 23.97
        StockData(5, 19) = 26.9
        StockData(5, 20) = 25.07
        StockData(5, 21) = 25.28
        StockData(5, 22) = 23.84
        StockData(5, 23) = 19.99
        StockData(5, 24) = 26.29
        StockData(5, 25) = 36.56
        StockData(5, 26) = 52.6
        StockData(5, 27) = 51.61
        StockData(5, 28) = 41.57
        StockData(5, 29) = 44.21
        StockData(5, 30) = 35.41
        StockData(5, 31) = 40.38
        StockData(5, 32) = 44.5
        StockData(5, 33) = 29.38
        StockData(5, 34) = 34.36
        StockData(5, 35) = 29.74
        StockData(5, 36) = 26.46
        StockData(5, 37) = 23.77
        StockData(5, 38) = 19.38
        StockData(5, 39) = 18.81
        StockData(5, 40) = 14.3
        StockData(5, 41) = 13.9
        StockData(5, 42) = 13.22
        StockData(5, 43) = 9.06
        StockData(5, 44) = 4.16
        StockData(5, 45) = 6.37
        StockData(5, 46) = 6
        StockData(5, 47) = 7
        StockData(5, 48) = 19.74
        StockData(6, 0) = 10
        StockData(6, 1) = 9.9
        StockData(6, 2) = 10.31
        StockData(6, 3) = 11.84
        StockData(6, 4) = 14.86
        StockData(6, 5) = 13.78
        StockData(6, 6) = 18.48
        StockData(6, 7) = 20.27
        StockData(6, 8) = 16.32
        StockData(6, 9) = 19.94
        StockData(6, 10) = 17.74
        StockData(6, 11) = 15.2
        StockData(6, 12) = 7.82
        StockData(6, 13) = 11.91
        StockData(6, 14) = 15.34
        StockData(6, 15) = 15.66
        StockData(6, 16) = 13.46
        StockData(6, 17) = 12.7
        StockData(6, 18) = 15.59
        StockData(6, 19) = 14
        StockData(6, 20) = 10.78
        StockData(6, 21) = 8.38
        StockData(6, 22) = 10.68
        StockData(6, 23) = 9.8
        StockData(6, 24) = 11.83
        StockData(6, 25) = 13.54
        StockData(6, 26) = 14.11
        StockData(6, 27) = 16.44
        StockData(6, 28) = 14.82
        StockData(6, 29) = 16.61
        StockData(6, 30) = 17.97
        StockData(6, 31) = 18.21
        StockData(6, 32) = 17.49
        StockData(6, 33) = 16.71
        StockData(6, 34) = 15.22
        StockData(6, 35) = 15.71
        StockData(6, 36) = 22.2
        StockData(6, 37) = 20.75
        StockData(6, 38) = 20.75
        StockData(6, 39) = 23.62
        StockData(6, 40) = 22.1
        StockData(6, 41) = 22.05
        StockData(6, 42) = 15.49
        StockData(6, 43) = 19.09
        StockData(6, 44) = 18.91
        StockData(6, 45) = 21.32
        StockData(6, 46) = 17.01
        StockData(6, 47) = 19
        StockData(6, 48) = 24.45
        StockData(7, 0) = 0
        StockData(7, 1) = 0
        StockData(7, 2) = 0
        StockData(7, 3) = 0
        StockData(7, 4) = 0
        StockData(7, 5) = 10.22
        StockData(7, 6) = 10.19
        StockData(7, 7) = 10.56
        StockData(7, 8) = 9.5
        StockData(7, 9) = 11.64
        StockData(7, 10) = 13.24
        StockData(7, 11) = 10.59
        StockData(7, 12) = 8.87
        StockData(7, 13) = 9.67
        StockData(7, 14) = 11.58
        StockData(7, 15) = 13.1
        StockData(7, 16) = 14.46
        StockData(7, 17) = 14.99
        StockData(7, 18) = 23.9
        StockData(7, 19) = 37.12
        StockData(7, 20) = 32.03
        StockData(7, 21) = 21.33
        StockData(7, 22) = 23.84
        StockData(7, 23) = 24.38
        StockData(7, 24) = 23.26
        StockData(7, 25) = 18.58
        StockData(7, 26) = 17.9
        StockData(7, 27) = 14.82
        StockData(7, 28) = 14.62
        StockData(7, 29) = 14.82
        StockData(7, 30) = 11.93
        StockData(7, 31) = 12.22
        StockData(7, 32) = 11.08
        StockData(7, 33) = 10.45
        StockData(7, 34) = 13.45
        StockData(7, 35) = 14.03
        StockData(7, 36) = 11.97
        StockData(7, 37) = 12.91
        StockData(7, 38) = 13.18
        StockData(7, 39) = 12.66
        StockData(7, 40) = 12.18
        StockData(7, 41) = 10.81
        StockData(7, 42) = 11.5
        StockData(7, 43) = 11.1
        StockData(7, 44) = 13.58
        StockData(7, 45) = 13.21
        StockData(7, 46) = 11.07
        StockData(7, 47) = 20.77
        StockData(7, 48) = 19.46
        StockData(8, 0) = 10
        StockData(8, 1) = 8.71
        StockData(8, 2) = 10.15
        StockData(8, 3) = 12.77
        StockData(8, 4) = 10.35
        StockData(8, 5) = 11.54
        StockData(8, 6) = 16.1
        StockData(8, 7) = 19.09
        StockData(8, 8) = 16.74
        StockData(8, 9) = 14.58
        StockData(8, 10) = 9.29
        StockData(8, 11) = 7.95
        StockData(8, 12) = 9.63
        StockData(8, 13) = 10.36
        StockData(8, 14) = 9.58
        StockData(8, 15) = 10.45
        StockData(8, 16) = 11.76
        StockData(8, 17) = 12.18
        StockData(8, 18) = 11.83
        StockData(8, 19) = 10.94
        StockData(8, 20) = 9.92
        StockData(8, 21) = 11.75
        StockData(8, 22) = 13.43
        StockData(8, 23) = 13.18
        StockData(8, 24) = 14.81
        StockData(8, 25) = 18.66
        StockData(8, 26) = 20.88
        StockData(8, 27) = 19.72
        StockData(8, 28) = 21.55
        StockData(8, 29) = 22.67
        StockData(8, 30) = 30.9
        StockData(8, 31) = 33.23
        StockData(8, 32) = 38.72
        StockData(8, 33) = 44.85
        StockData(8, 34) = 39.42
        StockData(8, 35) = 36
        StockData(8, 36) = 43.62
        StockData(8, 37) = 47.73
        StockData(8, 38) = 53.73
        StockData(8, 39) = 45.36
        StockData(8, 40) = 46.44
        StockData(8, 41) = 42.33
        StockData(8, 42) = 32.1
        StockData(8, 43) = 36.06
        StockData(8, 44) = 27.51
        StockData(8, 45) = 43.89
        StockData(8, 46) = 30.96
        StockData(8, 47) = 37.95
        StockData(8, 48) = 49.4
        StockData(9, 0) = 10
        StockData(9, 1) = 9.96
        StockData(9, 2) = 10.01
        StockData(9, 3) = 11.14
        StockData(9, 4) = 11.81
        StockData(9, 5) = 12.6
        StockData(9, 6) = 14.46
        StockData(9, 7) = 20.25
        StockData(9, 8) = 19.58
        StockData(9, 9) = 15.03
        StockData(9, 10) = 13.55
        StockData(9, 11) = 12.29
        StockData(9, 12) = 11.61
        StockData(9, 13) = 11.68
        StockData(9, 14) = 11.51
        StockData(9, 15) = 11.43
        StockData(9, 16) = 11.95
        StockData(9, 17) = 12.9
        StockData(9, 18) = 13.3
        StockData(9, 19) = 12.31
        StockData(9, 20) = 10.6
        StockData(9, 21) = 10.7
        StockData(9, 22) = 10.88
        StockData(9, 23) = 11.58
        StockData(9, 24) = 12.19
        StockData(9, 25) = 13.47
        StockData(9, 26) = 13.59
        StockData(9, 27) = 12.9
        StockData(9, 28) = 11.86
        StockData(9, 29) = 10.26
        StockData(9, 30) = 8.72
        StockData(9, 31) = 9.61
        StockData(9, 32) = 8.58
        StockData(9, 33) = 9.14
        StockData(9, 34) = 10.21
        StockData(9, 35) = 8.49
        StockData(9, 36) = 8.81
        StockData(9, 37) = 9.73
        StockData(9, 38) = 8.33
        StockData(9, 39) = 8.53
        StockData(9, 40) = 10.92
        StockData(9, 41) = 11.46
        StockData(9, 42) = 9.36
        StockData(9, 43) = 7.86
        StockData(9, 44) = 6.93
        StockData(9, 45) = 8.12
        StockData(9, 46) = 7
        StockData(9, 47) = 6.49
        StockData(9, 48) = 7.97
        StockData(10, 0) = 0
        StockData(10, 1) = 0
        StockData(10, 2) = 0
        StockData(10, 3) = 0
        StockData(10, 4) = 0
        StockData(10, 5) = 0
        StockData(10, 6) = 0
        StockData(10, 7) = 0
        StockData(10, 8) = 0
        StockData(10, 9) = 0
        StockData(10, 10) = 0
        StockData(10, 11) = 0
        StockData(10, 12) = 0
        StockData(10, 13) = 0
        StockData(10, 14) = 0
        StockData(10, 15) = 0
        StockData(10, 16) = 0
        StockData(10, 17) = 0
        StockData(10, 18) = 0
        StockData(10, 19) = 0
        StockData(10, 20) = 0
        StockData(10, 21) = 0
        StockData(10, 22) = 0
        StockData(10, 23) = 0
        StockData(10, 24) = 0
        StockData(10, 25) = 0
        StockData(10, 26) = 0
        StockData(10, 27) = 10
        StockData(10, 28) = 6.12
        StockData(10, 29) = 7.82
        StockData(10, 30) = 5.64
        StockData(10, 31) = 6.12
        StockData(10, 32) = 4.37
        StockData(10, 33) = 3.64
        StockData(10, 34) = 2.3
        StockData(10, 35) = 3.02
        StockData(10, 36) = 2.56
        StockData(10, 37) = 2.59
        StockData(10, 38) = 2.66
        StockData(10, 39) = 3.77
        StockData(10, 40) = 4.76
        StockData(10, 41) = 5.53
        StockData(10, 42) = 4.52
        StockData(10, 43) = 6.27
        StockData(10, 44) = 6.7
        StockData(10, 45) = 5.04
        StockData(10, 46) = 4.51
        StockData(10, 47) = 6.38
        StockData(10, 48) = 8.51
        StockData(11, 0) = 10
        StockData(11, 1) = 8.86
        StockData(11, 2) = 11.72
        StockData(11, 3) = 11.83
        StockData(11, 4) = 16.02
        StockData(11, 5) = 16.14
        StockData(11, 6) = 20.59
        StockData(11, 7) = 27.14
        StockData(11, 8) = 33.44
        StockData(11, 9) = 36.4
        StockData(11, 10) = 38.58
        StockData(11, 11) = 38.33
        StockData(11, 12) = 13.84
        StockData(11, 13) = 17.47
        StockData(11, 14) = 23.83
        StockData(11, 15) = 23.93
        StockData(11, 16) = 26.57
        StockData(11, 17) = 28.76
        StockData(11, 18) = 44.46
        StockData(11, 19) = 48.71
        StockData(11, 20) = 42.46
        StockData(11, 21) = 42.39
        StockData(11, 22) = 52.41
        StockData(11, 23) = 51.42
        StockData(11, 24) = 63.05
        StockData(11, 25) = 56.36
        StockData(11, 26) = 63.03
        StockData(11, 27) = 74.76
        StockData(11, 28) = 71.08
        StockData(11, 29) = 62.57
        StockData(11, 30) = 67.62
        StockData(11, 31) = 84.76
        StockData(11, 32) = 62.07
        StockData(11, 33) = 48.98
        StockData(11, 34) = 46.31
        StockData(11, 35) = 45.59
        StockData(11, 36) = 48.84
        StockData(11, 37) = 53.3
        StockData(11, 38) = 45.91
        StockData(11, 39) = 60.96
        StockData(11, 40) = 62.93
        StockData(11, 41) = 51.58
        StockData(11, 42) = 50.88
        StockData(11, 43) = 56.78
        StockData(11, 44) = 53.51
        StockData(11, 45) = 64.54
        StockData(11, 46) = 46.96
        StockData(11, 47) = 51.03
        StockData(11, 48) = 55.82




        For i = 0 To 11
            Stonks(i) = New Stocks
        Next

        Stonks(0).Name = "Balfour Beatty (GBP)"
        Stonks(1).Name = "Barclays (GBP)"
        Stonks(2).Name = "BlackBerry (USD)"
        Stonks(3).Name = "BP (GBP)"
        Stonks(4).Name = "EDF (EUR)"
        Stonks(5).Name = "Gamestop (USD)"
        Stonks(6).Name = "Goldman Sachs (USD)"
        Stonks(7).Name = "Ishares Silver (USD)"
        Stonks(8).Name = "Ryanair (EUR)"
        Stonks(9).Name = "Sainsburys (GBP)"
        Stonks(10).Name = "Twitter (USD)"
        Stonks(11).Name = "Volkswagen (EUR)"


        'LabelMoney.Text = "Current Money Available - "

        TextBoxCash.Text = Math.Round(Money, 2)


        UpdateData()
        InitialiseTable()
        Timer1.Start()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        GamePaused = False
        ButtonStart.Hide()
    End Sub



    Sub UpdateData()

        Dim tempsum As Double = Money

        For i = 0 To Stonks.Length - 1
            Stonks(i).Price = StockData(i, Time)
            If Time = 0 Then
                Stonks(i).PriceChange = 0
            Else
                Stonks(i).PriceChange = Math.Round(((StockData(i, Time) / StockData(i, Time - 1)) - 1) * 100)

                'check if a stock is new to the market
                If Stonks(i).Price <> 0 And StockData(i, Time - 1) = 0 Then
                    MessageBox.Show(Stonks(i).Name & " is now available to trade")
                End If

            End If
            Stonks(i).ValueOwned = Stonks(i).NumberOwned * Stonks(i).Price
            tempsum += Stonks(i).ValueOwned
        Next


        TextBoxCash.Text = Math.Round(Money, 2)
        TextBoxWealth.Text = Math.Round(tempsum, 2)

    End Sub


    Sub InitialiseTable()
        For i = 0 To Stonks.Length - 1
            DataGridView1.Rows.Add(Stonks(i).Name, Stonks(i).Price, Stonks(i).PriceChange, Stonks(i).NumberOwned, Stonks(i).ValueOwned, "", "Buy")
        Next
        DataGridView1.ClearSelection()
    End Sub



    Event DataGridView1ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            RaiseEvent DataGridView1ButtonClick(senderGrid, e)
        End If
    End Sub




    Private Sub DataGridView1_ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles Me.DataGridView1ButtonClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            Dim i As Integer = e.RowIndex

            If Stonks(i).Price = 0 Then
                MessageBox.Show(Stonks(i).Name & " is not available yet")
                Exit Sub
            End If

            If e.ColumnIndex = 5 Then
                'selling code
                If Stonks(i).NumberOwned = 0 Then
                    MessageBox.Show("You do not have any " & Stonks(i).Name & " stock to sell!")
                    Exit Sub
                Else
                    Stonks(i).NumberOwned -= 1
                    Money += Stonks(i).Price
                    'update stats
                    Stonks(i).StatsMostTrades += 1
                    Stonks(i).StatsProfit += Stonks(i).Price
                End If

            ElseIf e.ColumnIndex = 6 Then
                'buying code
                If Stonks(i).Price > Money Then
                    MessageBox.Show("You cannot afford any " & Stonks(i).Name & " stock!")
                    Exit Sub
                Else
                    Stonks(i).NumberOwned += 1
                    Money -= Stonks(i).Price
                    'update stats
                    Stonks(i).StatsMostTrades += 1
                    Stonks(i).StatsProfit -= Stonks(i).Price
                    If Stonks(i).NumberOwned > Stonks(i).StatsMostSharesAtOnce Then
                        Stonks(i).StatsMostSharesAtOnce = Stonks(i).NumberOwned
                    End If
                End If
            End If

        End If

        UpdateData()
        UpdateTable()

    End Sub

    Sub UpdateTable()
        DataGridView1.Rows.Clear()
        Dim junk As Integer
        Dim Fontsize As Integer = 12
        If TextBoxFontSize.Text <> "" Then
            If Integer.TryParse(TextBoxFontSize.Text, junk) = True Then
                Fontsize = Integer.Parse(TextBoxFontSize.Text)

            End If
        End If
        If Fontsize = 0 Then
            Fontsize = 12
        End If


        If CheckBox1.Checked = True Then
            DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", Fontsize, FontStyle.Bold)
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", Fontsize, FontStyle.Bold)
        Else
            DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", Fontsize)
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", Fontsize)
        End If

        Dim StringBuy As String = "Buy"
        Dim StringSell As String = "Sell"

        For i = 0 To Stonks.Length - 1


            DataGridView1.Rows.Add(Stonks(i).Name, Stonks(i).Price, Stonks(i).PriceChange, Stonks(i).NumberOwned, Stonks(i).ValueOwned)
            DataGridView1.Rows(i).Height = Fontsize * 2
            If Stonks(i).PriceChange < 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Tomato
            ElseIf Stonks(i).PriceChange > 0 Then
                DataGridView1.Rows(i).DefaultCellStyle.ForeColor = Color.Green
            End If
            If Stonks(i).NumberOwned = 0 Then
                StringSell = ""
                DataGridView1.Rows(i).Cells(5).Value = ""
            Else
                StringSell = "Sell"
                DataGridView1.Rows(i).Cells(5).Value = "Sell"
            End If
            If Stonks(i).Price > Money Then
                StringBuy = ""
                DataGridView1.Rows(i).Cells(6).Value = ""
            Else
                StringBuy = "Buy"
                DataGridView1.Rows(i).Cells(6).Value = "Buy"
            End If

            If Stonks(i).Price = 0 Then
                DataGridView1.Rows(i).Cells(6).Value = ""
            End If

        Next
        DataGridView1.ClearSelection()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If GamePaused = True Then
            Exit Sub
        End If

        GameTimeInSeconds += 1

        If GameTimeInSeconds = TimeIntervalInSeconds Then
            Time += 1
            GameTimeInSeconds = 0
            If Time = 49 Then
                GamePaused = True
                Endgame()
                Exit Sub
            End If
            UpdateData()
            UpdateTable()
            TimeCheckStockRecords()
        End If

        LabelCurrentTime.Text = TimeArray(Time)
        If Time = 48 Then
            LabelNextTime.Text = TimeIntervalInSeconds - GameTimeInSeconds & " s until its GAME OVER"
        Else
            LabelNextTime.Text = "Next time in: " & TimeIntervalInSeconds - GameTimeInSeconds
        End If


    End Sub

    Sub TimeCheckStockRecords()

        For i = 0 To Stonks.Length - 1
            If Stonks(i).NumberOwned > 0 Then
                'check if theres an existing streak
                If Stonks(i).StatsHoldTimeCurrent = 0 Then
                    'if there isnt, start one
                    Stonks(i).StatsHoldStartCurrent = Time - 1
                End If
                Stonks(i).StatsHoldTimeCurrent += 1
                'check if the current record is the highest
                If Stonks(i).StatsHoldTimeCurrent > Stonks(i).StatsHoldTimeRecord Then
                    Stonks(i).StatsHoldTimeRecord = Stonks(i).StatsHoldTimeCurrent
                    Stonks(i).StatsHoldStartRecord = Stonks(i).StatsHoldStartCurrent
                End If
                'check if a streak has just ended, if so end it
            ElseIf Stonks(i).NumberOwned = 0 Then
                'if the current streak was the record, preserve it
                If Stonks(i).StatsHoldTimeRecord = Stonks(i).StatsHoldTimeCurrent Then
                    Stonks(i).StatsHoldEndRecord = Time - 1
                End If
                Stonks(i).StatsHoldStartCurrent = 0
            End If

            'And Stonks(i).StatsHoldTimeCurrent > 0 
        Next

    End Sub

    Sub Endgame()

        'sell all stocks for profit
        For i = 0 To Stonks.Length - 1
            Stonks(i).StatsProfit += (Stonks(i).Price * Stonks(i).NumberOwned)
            Money += (Stonks(i).Price * Stonks(i).NumberOwned)
            Stonks(i).NumberOwned = 0
        Next

        'update the stock by stock records
        TimeCheckStockRecords()

        GenerateFinalStats()

        Dim CloseForm = New GameEndStats()
        CloseForm.Show()
        Me.Hide()



    End Sub

    Private Sub TextBoxFontSize_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFontSize.TextChanged
        UpdateTable()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateTable()
    End Sub

    'this subs aim is to go through all the statistics that have been accumulated for each stock as part of STONKS, and pull out the record values for a final report
    Sub GenerateFinalStats()


        FinalStatistics.StatMostStockAtOnce = 0
        FinalStatistics.StatOverallTradeNumber = 0
        FinalStatistics.StatHighestTradePercentageOneStock = 0
        FinalStatistics.StatHighestProfitOneStock = 0
        FinalStatistics.StatBiggestLossOneStock = 0
        FinalStatistics.StatLongestHoldOneStock = 0
        FinalStatistics.StatTotalMoney = 0



        'biggest loss
        For i = 0 To Stonks.Length - 1
            If Stonks(i).StatsProfit <> 0 Then
                If Stonks(i).StatsProfit < FinalStatistics.StatBiggestLossOneStock Then
                    FinalStatistics.StatBiggestLossOneStock = Stonks(i).StatsProfit
                    FinalStatistics.DetailBiggestLossOneStock = "loss on " & Stonks(i).Name
                End If
            End If
        Next

        'biggest gain
        For i = 0 To Stonks.Length - 1
            If Stonks(i).StatsProfit <> 0 Then
                If Stonks(i).StatsProfit > FinalStatistics.StatHighestProfitOneStock Then
                    FinalStatistics.StatHighestProfitOneStock = Stonks(i).StatsProfit
                    FinalStatistics.DetailHighestProfitOneStock = "gain on " & Stonks(i).Name
                End If
            End If
        Next

        'total transactions
        For i = 0 To Stonks.Length - 1
            FinalStatistics.StatOverallTradeNumber += Stonks(i).StatsMostTrades
        Next

        'percentage transactions on one stock
        Dim temp As Double = 0
        For i = 0 To Stonks.Length - 1
            temp = Math.Round((Stonks(i).StatsMostTrades / FinalStatistics.StatOverallTradeNumber) * 100, 2)
            If temp > FinalStatistics.StatHighestTradePercentageOneStock Then
                FinalStatistics.StatHighestTradePercentageOneStock = temp
                FinalStatistics.DetailHighestTradePercentageOneStock = "percent of trades in " & Stonks(i).Name
            End If
        Next

        'most stock held at once
        For i = 0 To Stonks.Length - 1
            If Stonks(i).StatsMostSharesAtOnce <> 0 Then
                If Stonks(i).StatsMostSharesAtOnce > FinalStatistics.StatMostStockAtOnce Then
                    FinalStatistics.StatMostStockAtOnce = Stonks(i).StatsMostSharesAtOnce
                    FinalStatistics.DetailMostStockAtOnce = "shares of " & Stonks(i).Name
                End If
            End If
        Next

        'longest hold
        For i = 0 To Stonks.Length - 1
            If Stonks(i).StatsHoldTimeRecord <> 0 Then
                If Stonks(i).StatsHoldTimeRecord > FinalStatistics.StatLongestHoldOneStock Then
                    FinalStatistics.StatLongestHoldOneStock = Stonks(i).StatsHoldTimeRecord
                    FinalStatistics.DetailLongestHoldOneStock = "held " & Stonks(i).Name & " from " & TimeArray(Stonks(i).StatsHoldStartRecord) & " until " & TimeArray(Stonks(i).StatsHoldEndRecord)
                End If
            End If
        Next

        'money
        FinalStatistics.StatTotalMoney = Money

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing

        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to end the game?", "Exit Game", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True

            ElseIf result = DialogResult.No Then
                e.Cancel = True

            ElseIf result = DialogResult.Yes Then
                Exit Sub
            End If

        End If

    End Sub


End Class





