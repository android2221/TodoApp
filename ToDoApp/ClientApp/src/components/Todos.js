import React, { Component } from 'react';

export class Todos extends Component {

    constructor(props) {
        super(props);
        this.state = {todos: []}
    }

    async componentDidMount(){
        const response = await fetch('api/todos');
        const data = await response.json();
        this.setState({todos: data})
    }

    render(){
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Title</th>
                    <th>Note</th>
                </tr>
            </thead>
            <tbody>
                {this.state.todos.map(todo =>
                    <tr key={todo.id}>
                    <td>{todo.id}</td>
                    <td>{todo.title}</td>
                    <td>{todo.note}</td>
                    </tr>
                )}
            </tbody>
        </table>
        )
    }



}