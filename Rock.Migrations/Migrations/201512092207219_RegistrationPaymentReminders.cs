// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
namespace Rock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    /// <summary>
    ///
    /// </summary>
    public partial class RegistrationPaymentReminders : Rock.Migrations.RockMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            //
            // todo: add SQL to add default payment reminder email text to current templates

            AddColumn("dbo.Registration", "LastPaymentReminderDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.RegistrationTemplate", "PaymentReminderFromName", c => c.String(maxLength: 200));
            AddColumn("dbo.RegistrationTemplate", "PaymentReminderFromEmail", c => c.String(maxLength: 200));
            AddColumn("dbo.RegistrationTemplate", "PaymentReminderSubject", c => c.String(maxLength: 200));
            AddColumn("dbo.RegistrationTemplate", "PaymentReminderEmailTemplate", c => c.String());
            AddColumn("dbo.RegistrationTemplate", "PaymentReminderTimeSpan", c => c.Int());
            AlterColumn("dbo.PrayerRequest", "LastName", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Registration", "IsTemporary");
            DropColumn("dbo.RegistrationTemplate", "AllowGroupPlacement");
        }
        
        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            AddColumn("dbo.RegistrationTemplate", "AllowGroupPlacement", c => c.Boolean(nullable: false));
            AddColumn("dbo.Registration", "IsTemporary", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PrayerRequest", "LastName", c => c.String(maxLength: 50));
            DropColumn("dbo.RegistrationTemplate", "PaymentReminderTimeSpan");
            DropColumn("dbo.RegistrationTemplate", "PaymentReminderEmailTemplate");
            DropColumn("dbo.RegistrationTemplate", "PaymentReminderSubject");
            DropColumn("dbo.RegistrationTemplate", "PaymentReminderFromEmail");
            DropColumn("dbo.RegistrationTemplate", "PaymentReminderFromName");
            DropColumn("dbo.Registration", "LastPaymentReminderDateTime");
        }
    }
}
