import React, { Component } from 'react';

export class Quizy extends Component {
  static displayName = Quizy.name;

  constructor(props) {
    super(props);
    this.state = { questions: [], loading: true };
  }

  componentDidMount() {
    this.fetchQuestions();
  }

  static renderQuestion(questions) {
    return (
        <></>
    )
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Quizy.fetchQuestions(this.state.questions);

    return (
      <div>
        <h1 id="tableLabel">Questions</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async fetchQuestions() {
    const response = await fetch('api/questions/getAll');
    const data = await response.json();
    this.setState({ questions: data, loading: false });
  }
}
