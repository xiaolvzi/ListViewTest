package md56acfac12b4e715649730cf3ad662d822;


public class DataViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ListViewTest.DataViewHolder, ListViewTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DataViewHolder.class, __md_methods);
	}


	public DataViewHolder ()
	{
		super ();
		if (getClass () == DataViewHolder.class)
			mono.android.TypeManager.Activate ("ListViewTest.DataViewHolder, ListViewTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
