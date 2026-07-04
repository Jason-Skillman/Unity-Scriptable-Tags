using System.Collections.Generic;
using UnityEngine;

namespace JasonSkillman.ScriptableTags
{
	public class TagComponent : MonoBehaviour
	{
		[SerializeField]
		private List<Tag> tags;

		public List<Tag> Tags
		{
			get => tags;
			set => tags = value;
		}
	}
}
