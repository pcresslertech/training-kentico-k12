//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.Training;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(Doctor.CLASS_NAME, typeof(Doctor))]

namespace CMS.DocumentEngine.Types.Training
{
	/// <summary>
	/// Represents a content item of type Doctor.
	/// </summary>
	public partial class Doctor : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Training.Doctor";


		/// <summary>
		/// The instance of the class that provides extended API for working with Doctor fields.
		/// </summary>
		private readonly DoctorFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// DoctorID.
		/// </summary>
		[DatabaseIDField]
		public int DoctorID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("DoctorID"), 0);
			}
			set
			{
				SetValue("DoctorID", value);
			}
		}


		/// <summary>
		/// First name.
		/// </summary>
		[DatabaseField]
		public string FirstName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FirstName"), @"");
			}
			set
			{
				SetValue("FirstName", value);
			}
		}


		/// <summary>
		/// Last name.
		/// </summary>
		[DatabaseField]
		public string LastName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LastName"), @"");
			}
			set
			{
				SetValue("LastName", value);
			}
		}


		/// <summary>
		/// Doctor degree.
		/// </summary>
		[DatabaseField]
		public string Degree
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Degree"), @"");
			}
			set
			{
				SetValue("Degree", value);
			}
		}


		/// <summary>
		/// Photo.
		/// </summary>
		[DatabaseField]
		public Guid Image
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("Image"), Guid.Empty);
			}
			set
			{
				SetValue("Image", value);
			}
		}


		/// <summary>
		/// Doctor specialty.
		/// </summary>
		[DatabaseField]
		public string Specialty
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Specialty"), @"");
			}
			set
			{
				SetValue("Specialty", value);
			}
		}


		/// <summary>
		/// Bio.
		/// </summary>
		[DatabaseField]
		public string Bio
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Bio"), @"");
			}
			set
			{
				SetValue("Bio", value);
			}
		}


		/// <summary>
		/// Emergency shift.
		/// </summary>
		[DatabaseField]
		public int EmergencyShift
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("EmergencyShift"), 0);
			}
			set
			{
				SetValue("EmergencyShift", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Doctor fields.
		/// </summary>
		[RegisterProperty]
		public DoctorFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Doctor fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class DoctorFields : AbstractHierarchicalObject<DoctorFields>
		{
			/// <summary>
			/// The content item of type Doctor that is a target of the extended API.
			/// </summary>
			private readonly Doctor mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="DoctorFields" /> class with the specified content item of type Doctor.
			/// </summary>
			/// <param name="instance">The content item of type Doctor that is a target of the extended API.</param>
			public DoctorFields(Doctor instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// DoctorID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.DoctorID;
				}
				set
				{
					mInstance.DoctorID = value;
				}
			}


			/// <summary>
			/// First name.
			/// </summary>
			public string FirstName
			{
				get
				{
					return mInstance.FirstName;
				}
				set
				{
					mInstance.FirstName = value;
				}
			}


			/// <summary>
			/// Last name.
			/// </summary>
			public string LastName
			{
				get
				{
					return mInstance.LastName;
				}
				set
				{
					mInstance.LastName = value;
				}
			}


			/// <summary>
			/// Doctor degree.
			/// </summary>
			public string Degree
			{
				get
				{
					return mInstance.Degree;
				}
				set
				{
					mInstance.Degree = value;
				}
			}


			/// <summary>
			/// Photo.
			/// </summary>
			public DocumentAttachment Image
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("Image");
				}
			}


			/// <summary>
			/// Doctor specialty.
			/// </summary>
			public string Specialty
			{
				get
				{
					return mInstance.Specialty;
				}
				set
				{
					mInstance.Specialty = value;
				}
			}


			/// <summary>
			/// Bio.
			/// </summary>
			public string Bio
			{
				get
				{
					return mInstance.Bio;
				}
				set
				{
					mInstance.Bio = value;
				}
			}


			/// <summary>
			/// Emergency shift.
			/// </summary>
			public int EmergencyShift
			{
				get
				{
					return mInstance.EmergencyShift;
				}
				set
				{
					mInstance.EmergencyShift = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Doctor" /> class.
		/// </summary>
		public Doctor() : base(CLASS_NAME)
		{
			mFields = new DoctorFields(this);
		}

		#endregion
	}
}