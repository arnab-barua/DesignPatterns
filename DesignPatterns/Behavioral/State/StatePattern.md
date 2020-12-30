<h3>State pattern</h3>
<p>
	State pattern allows an object of a class to behave differently based on it's own state.
</p>
<strong>When to use?</strong>
<p>
	When we have multiple decision making,we can use State pattern.
</p>

<strong>Example</strong>
<p>
	Suppose we are developing a paint like software. Based on the tool selected, mouse event works differently in the canvas. 
	When we have selected the 'Selection' tool, <i>MouseDown</i> and <i>MouseUp</i> event we select a ractangle in the canvas.
	In another case if we select the 'Paint' tool, <i>MouseDown</i> and <i>MouseUp</i> event we paint a shape in the canvas.
	Here the canvas's behavior is changed based on the selected tool. In this situation we can use STATE pattern to solve this issue.
	Here different tool indicates the different state of the canvas.
</p>

<strong>Terminology</strong>
<ul>
	<li>Context (Canvas) - Whose behavior changes.</li>
	<li>State (ITool).</li>
	<li>Concrete States (ITool implementations - Selection, Brush).</li>
</ul>

<strong><i>References</i></strong>
<ul>
	<li>
		<a target="_blank" href="https://en.wikipedia.org/wiki/State_pattern">Wikipedia</a>
	</li>
	<li>
		<a target="_blank" href="https://www.tutorialspoint.com/design_pattern/state_pattern.htm">Tutorials Point</a>
	</li>
</ul>
