namespace Fable.DateFunctions

open System

[<AutoOpen>]
module MonthHelpers =
    type DateTime with
        member inline date.AddMonths(months: int) : DateTime = ExternalDateFns.addMonths date months
        member inline date.DifferenceInCalendarMonths(otherDate : DateTime) : int = ExternalDateFns.differenceInCalendarMonths date otherDate
        member inline date.DifferenceInMonths(otherDate : DateTime) : int = ExternalDateFns.differenceInMonths date otherDate
        member inline date.EndOfMonth() : DateTime = ExternalDateFns.endOfMonth date
        member inline date.GetDaysInMonth() : int = ExternalDateFns.getDaysInMonth date
        member inline date.IsFirstDayOfMonth() : bool = ExternalDateFns.isFirstDayOfMonth date
        member inline date.IsLastDayOfMonth() : bool = ExternalDateFns.isLastDayOfMonth date
        member inline date.IsInTheSameMonthAs(otherDate: DateTime) : bool = ExternalDateFns.isSameMonth date otherDate
        member inline date.IsInThisMonth() : bool = ExternalDateFns.isThisMonth date
        member inline date.SetMonth(month : Months) : DateTime = ExternalDateFns.setMonth date month
        member inline date.StartOfMonth() : DateTime = ExternalDateFns.startOfMonth date
        /// Returns the start of day of the previous month relative to the month of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddMonths(-1).StartOfMonth().StartOfDay()`
        member inline date.StartOfPreviousMonth() : DateTime = date.AddMonths(-1).StartOfMonth().StartOfDay()
        /// Returns the end of day of the previous month relative to the month of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddMinutes(-1).EndOfMonth().EndOfDay()`
        member inline date.EndOfPreviousMonth() : DateTime = date.AddMinutes(-1).EndOfMonth().EndOfDay()
        /// Returns the start of day of the next month relative to the month of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddMonths(1).StartOfMonth().StartOfDay()`
        member inline date.StartOfNextMonth() : DateTime = date.AddMonths(1).StartOfMonth().StartOfDay()
        /// Returns the end of day of the next month relative to the month of the current instance of `DateTime`.
        ///
        /// Same as `{DateTime}.AddMonths(1).EndOfMonth().EndOfDay()`
        member inline date.EndOfNextMonth() : DateTime = date.AddMonths(1).EndOfMonth().EndOfDay()
        member inline date.SubtractMonths(months: int) : DateTime = ExternalDateFns.subMonths date months
