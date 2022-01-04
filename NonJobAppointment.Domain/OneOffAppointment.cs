﻿namespace NonJobAppointment.Domain;

public sealed record OneOffAppointment(
        Guid Id,
        string Title,
        string Summary,
        DateOnly Date,
        TimeFrame TimeFrame,
        long TechnicianId,
        int TimeseetCode
) : Appointment(Id, Title, Summary, TimeFrame, TechnicianId, TimeseetCode);
