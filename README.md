Minimal code to produce problem with Audit.net.

Summary:  There are two classes in play here, Company and Employee.  Company works as expected, when a new company is created, Audit_Company populates correctly.
Employee does not function as expected.  When dbContext.SaveChanges() is called, program execution stops and SYSTEM.REFLECTION.TARGETEXCEPTION: 'Object does not match is thrown.
My initial thoughts were that the owned entity ADDRESS was causing the problem, so I have marked those as [AuditIgnore], and expanded these to include the calculated field Full name,
but the error is still thrown.

I've drilled down in the error, and noted that the actual employee entry is actually saved into the database, but the Audit_Employee entry is not, and that the dbugger, if I am
reading it correctly, has no items in the Audit_Employee model.

I'm unsure of how to proceed at this point, and do not have any experience to guide me as this is my first use of Audit.net, so I'm reaching out for help on this one.
