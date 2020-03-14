class Post extends React.Component {
  state = {
    title: "Post",
    body: "lol"
  };
  render() {
    return (
      <Div>
        <h3>{this.title}</h3>
        <p>{this.body}</p>
      </Div>
    );
  }
}
