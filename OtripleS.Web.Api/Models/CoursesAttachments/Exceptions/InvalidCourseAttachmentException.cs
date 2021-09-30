﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace OtripleS.Web.Api.Models.CourseAttachments.Exceptions
{
    public class InvalidCourseAttachmentException : Xeption
    {
        public InvalidCourseAttachmentException(string parameterName, object parameterValue)
            : base($"Invalid Course Attachment, " +
                  $"ParameterName: {parameterName}, " +
                  $"ParameterValue: {parameterValue}.")
        { }

        public InvalidCourseAttachmentException()
            : base("Invalid course attachment. Please fix the errors and try again.") { }
    }
}
